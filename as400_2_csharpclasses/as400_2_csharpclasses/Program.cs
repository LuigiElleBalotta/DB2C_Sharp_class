using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using IBM.Data.DB2.iSeries;

namespace as400_2_csharpclasses
{
    class Program
    {
        static iDB2Connection conn = null;
        static iDB2DataReader row = null;
        static iDB2Command cmd = null;

        static void Main(string[] args)
        {
            //Nomi tabelle
            //SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DBNAME';

            //Nomi colonne
            //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=? ORDER BY ORDINAL_POSITION;

            //numerocolonne
            //SELECT max(ORDINAL_POSITION) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=?;
            Console.WriteLine("host: ");
            string host = Console.ReadLine();

            Console.WriteLine("username: ");
            string user = Console.ReadLine();

            Console.WriteLine("password: ");
            string password = Console.ReadLine();

            Console.WriteLine("DB Name: ");
            string dbname = Console.ReadLine();

            Console.WriteLine("Namespace: ");
            string namespacename = Console.ReadLine();

            conn = new iDB2Connection("Data Source="+host+";user id="+user+";password="+password+";");
            conn.Open();
            cmd = new iDB2Command("", conn);
            cmd.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '" + dbname + "'";
            row = cmd.ExecuteReader();
            List<string> tablenames = new List<string>();
            while (row.Read())
            {
                tablenames.Add(row["TABLE_NAME"].ToString());
            }
            row.Close();
            foreach (var nome in tablenames)
            {
                Console.WriteLine(nome);
                cmd = new iDB2Command("", conn);
                cmd.CommandText = "SELECT COLUMN_NAME, COLUMN_DEFAULT, IS_NULLABLE, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME= '" + nome + "' AND TABLE_SCHEMA = '" + dbname + "' ORDER BY ORDINAL_POSITION";
                List<string> columnNames = new List<string>();
                List<string> columnDefaults = new List<string>();
                List<string> areNullables = new List<string>();
                List<string> dataTypes = new List<string>();
                row = cmd.ExecuteReader();
                while (row.Read())
                {
                    columnNames.Add(row["COLUMN_NAME"].ToString());
                    columnDefaults.Add(row["COLUMN_DEFAULT"].ToString());
                    areNullables.Add(row["IS_NULLABLE"].ToString());
                    dataTypes.Add(row["DATA_TYPE"].ToString());
                }
                row.Close();

                for (int k = 0; k < columnNames.Count; k++)
                {
                    if (dataTypes[k].ToLower() == "varchar" || dataTypes[k].ToLower() == "date" || dataTypes[k].ToLower() == "timestamp" || dataTypes[k].ToLower() == "text" || dataTypes[k].ToLower() == "datetime" || dataTypes[k].ToLower() == "national character large object" || dataTypes[k].ToLower() == "national character varying")
                        dataTypes[k] = "string";
                    if (dataTypes[k].ToLower() == "tinyint" || dataTypes[k].ToLower() == "bigint" || dataTypes[k].ToLower() == "smallint" || dataTypes[k].ToLower() == "mediumint" || dataTypes[k].ToLower() == "bit" || dataTypes[k].ToLower() == "integer")
                        dataTypes[k] = "int";

                    if (dataTypes[k].ToLower() == "decimal" || dataTypes[k].ToLower() == "numeric")
                        dataTypes[k] = "double";

                    if (dataTypes[k].ToLower() == "character" || dataTypes[k].ToLower() == "character varying")
                        dataTypes[k] = "string";

                    if (columnNames[k].ToLower() == "class")
                        columnNames[k] = "class_var";

                    if (columnNames[k].ToLower() == "int")
                        columnNames[k] = "int_var";
                        

                }

                string pathstring = "./";

                pathstring = Path.Combine(pathstring, nome + ".cs");
                if (!File.Exists(pathstring))
                {
                    StreamWriter sw = File.AppendText(pathstring);
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("using System.Linq;");
                    sw.WriteLine("using System.Threading.Tasks;");
                    sw.WriteLine("using System.Text;");
                    sw.WriteLine("using IBM.Data.DB2.iSeries;");
                    sw.WriteLine("");
                    sw.WriteLine("namespace " + namespacename);
                    sw.WriteLine("{");
                    sw.WriteLine("\tclass " + UppercaseFirst(nome));
                    sw.WriteLine("\t{");
                    int i = 0;
                    foreach (var columnName in columnNames)
                    {
                        string defaultvalue = "null";
                        if (columnDefaults[i] != "")
                        {
                            if (Regex.IsMatch(columnDefaults[i], @"\d"))
                                defaultvalue = columnDefaults[i];
                            else
                                defaultvalue = "\"" + columnDefaults[i] + "\"";
                        }
                        if ((dataTypes[i].ToLower() == "int" || dataTypes[i].ToLower() == "double") && columnDefaults[i] == "")
                            defaultvalue = "0";

                        if ((dataTypes[i].ToLower() == "char" && columnDefaults[i].ToLower() == "null") || (dataTypes[i].ToLower() == "char" && columnDefaults[i].ToLower() == ""))
                            defaultvalue = "Char.MinValue";

                        if ((dataTypes[i].ToLower() == "char" && columnDefaults[i] != ""))
                            defaultvalue = "'" + columnDefaults[i] + "'";

                        if (((dataTypes[i].ToLower() == "float" && columnDefaults[i].ToLower() == "null") || (dataTypes[i].ToLower() == "float" && columnDefaults[i] == "")) || ((dataTypes[i].ToLower() == "double" && columnDefaults[i].ToLower() == "null") || (dataTypes[i].ToLower() == "double" && columnDefaults[i] == "")))
                            defaultvalue = "0.0f";

                        if ((dataTypes[i].ToLower() == "float" && columnDefaults[i] != "") || (dataTypes[i].ToLower() == "double" && columnDefaults[i] != ""))
                            defaultvalue = columnDefaults[i] + "f";

                        if (defaultvalue == "\"''\"" || defaultvalue == "\"CURRENT_DATE\"" || defaultvalue == "\"' '\"")
                            defaultvalue = "\"\"";
                        sw.WriteLine("\t\t" + dataTypes[i] + " " + columnName.ToLower() + " { get; set; } = " + defaultvalue + ";");
                        sw.WriteLine("\t\t" + dataTypes[i] + " OLD_" + columnName.ToLower() + " = " + defaultvalue + ";");
                        sw.WriteLine("");
                        i++;
                    }
                    sw.WriteLine("\t\tiDB2Connection conn = new iDB2Connection(\"Data Source=<HOST>;user id=<USER>;password=<PASSWORD>;\");");
                    sw.WriteLine("");

                    List<string> parametri = new List<string>();
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        parametri.Add(dataTypes[k] + " _" + columnNames[k].ToLower());
                    }
                    var parametristring = String.Join(", ", parametri);
                    sw.WriteLine("\t\tpublic " + UppercaseFirst(nome) + "() { }");
                    sw.WriteLine("");
                    sw.WriteLine("\t\tpublic " + UppercaseFirst(nome) + "(" + parametristring + ")");
                    sw.WriteLine("\t\t{");
                    for (int k = 0; k < parametri.Count; k++)
                    {
                        sw.WriteLine("\t\t\t" + columnNames[k].ToLower() + " = _" + columnNames[k].ToLower() + ";");
                    }
                    sw.WriteLine("\t\t\tupdateOldValues();");
                    sw.WriteLine("\t\t}");

                    sw.WriteLine("");
                    sw.WriteLine("\t\tpublic void delete()");
                    sw.WriteLine("\t\t{");
                    sw.WriteLine("\t\t\tconn.Open();");
                    sw.WriteLine("\t\t\tiDB2Command cmd = new iDB2Command(\"\", conn);");
                    List<string> whereStatementArray = new List<string>();
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        whereStatementArray.Add(columnNames[k] + " = @" + columnNames[k]);
                    }
                    var whereStatementString = String.Join(" AND ", whereStatementArray);
                    sw.WriteLine("\t\t\tcmd.CommandText = \"DELETE FROM " + dbname + "." + nome + " WHERE " + whereStatementString + "\";");
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tiDB2Parameter " + columnNames[k].ToLower() + "Parameter = new iDB2Parameter(\"@" + columnNames[k] + "\", iDB2DbType.iDB2VarChar, 0);"); //always varchar so i don't have problem to handle strings
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\t" + columnNames[k].ToLower() + "Parameter.Value = " + columnNames[k].ToLower() + ";");
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tcmd.Parameters.Add(" + columnNames[k].ToLower() + "Parameter);");
                    }
                    sw.WriteLine("\t\t\tcmd.ExecuteNonQuery();");
                    sw.WriteLine("\t\t\tconn.Close();");
                    sw.WriteLine("\t\t}");
                    sw.WriteLine("");
                    sw.WriteLine("\t\tpublic void update()");
                    sw.WriteLine("\t\t{");
                    sw.WriteLine("\t\t\tconn.Open();");
                    sw.WriteLine("\t\t\tiDB2Command cmd = new iDB2Command(\"\", conn);");
                    List<string> updateStatementArray = new List<string>();
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        updateStatementArray.Add(columnNames[k] + " = @new" + columnNames[k]);
                    }
                    var updateStatementString = String.Join(", ", updateStatementArray);
                    sw.WriteLine("\t\t\tcmd.CommandText = \"UPDATE " + dbname + "." + nome + " SET " + updateStatementString + " WHERE " + whereStatementString + "\";");
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tiDB2Parameter OLD_" + columnNames[k].ToLower() + "Parameter = new iDB2Parameter(\"@" + columnNames[k] + "\", iDB2DbType.iDB2VarChar, 0);");
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tiDB2Parameter " + columnNames[k].ToLower() + "Parameter = new iDB2Parameter(\"@new" + columnNames[k] + "\", iDB2DbType.iDB2VarChar, 0);");
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\t" + columnNames[k].ToLower() + "Parameter.Value = " + columnNames[k].ToLower() + ";");
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tOLD_" + columnNames[k].ToLower() + "Parameter.Value = OLD_" + columnNames[k].ToLower() + ";");
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tcmd.Parameters.Add(" + columnNames[k].ToLower() + "Parameter);");
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tcmd.Parameters.Add(OLD_" + columnNames[k].ToLower() + "Parameter);");
                    }
                    sw.WriteLine("\t\t\tcmd.ExecuteNonQuery();");
                    sw.WriteLine("\t\t\tconn.Close();");
                    sw.WriteLine("\t\t\tupdateOldValues();");
                    sw.WriteLine("\t\t}");
                    sw.WriteLine("");

                    sw.WriteLine("\t\tprivate void updateOldValues()");
                    sw.WriteLine("\t\t{");
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tOLD_" + columnNames[k].ToLower() + " = " + columnNames[k].ToLower() + ";");
                    }
                    sw.WriteLine("\t\t}");
                    sw.WriteLine("\t}");
                    sw.WriteLine("}");
                    sw.Close();
                }

            }


            conn.Close();
            Console.ReadLine();
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }
    }
}
