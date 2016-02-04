using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Database2Class_converter
{
    class Program
    {
        static MySqlConnection conn = null;
        static MySqlDataReader row = null;
        static MySqlCommand cmd = null;

        static void Main(string[] args)
        {
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

            conn = new MySqlConnection("server="+host+";user="+user+";database=" + dbname + ";password="+password+";");
            conn.Open();
            cmd = new MySqlCommand("", conn);
            cmd.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '"+dbname+"';";
            row = cmd.ExecuteReader();
            List<string> tablenames = new List<string>();
            while(row.Read())
            {
                tablenames.Add(row["TABLE_NAME"].ToString());
            }
            row.Close();
            foreach(var nome in tablenames)
            {
                Console.WriteLine(nome);
                cmd = new MySqlCommand("", conn);
                cmd.CommandText = "SELECT COLUMN_NAME, COLUMN_DEFAULT, IS_NULLABLE, DATA_TYPE, COLUMN_TYPE, COLUMN_COMMENT FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME= '"+nome+"' AND TABLE_SCHEMA = '"+dbname+"' ORDER BY ORDINAL_POSITION;";
                List<string> columnNames = new List<string>();
                List<string> columnDefaults = new List<string>();
                List<string> areNullables = new List<string>();
                List<string> dataTypes = new List<string>();
                List<string> columnTypes = new List<string>();
                List<string> columnComments = new List<string>();
                row = cmd.ExecuteReader();
                while(row.Read())
                {
                    columnNames.Add(row["COLUMN_NAME"].ToString());
                    columnDefaults.Add(row["COLUMN_DEFAULT"].ToString());
                    areNullables.Add(row["IS_NULLABLE"].ToString());
                    dataTypes.Add(row["DATA_TYPE"].ToString());
                    columnTypes.Add(row["COLUMN_TYPE"].ToString());
                    columnComments.Add(row["COLUMN_COMMENT"].ToString());
                }
                row.Close();

                for (int k = 0; k < columnNames.Count; k++)
                {
                    if (dataTypes[k].ToLower() == "tinytext" || dataTypes[k].ToLower() == "mediumtext" || dataTypes[k].ToLower() == "longtext" || dataTypes[k].ToLower() == "time" || dataTypes[k].ToLower() == "year" || dataTypes[k] == "varchar" || dataTypes[k].ToLower() == "date" || dataTypes[k].ToLower() == "timestamp" || dataTypes[k].ToLower() == "text" || dataTypes[k].ToLower() == "datetime")
                        dataTypes[k] = "string";
                    if (dataTypes[k].ToLower() == "tinyint" || dataTypes[k].ToLower() == "bigint" || dataTypes[k].ToLower() == "smallint" || dataTypes[k].ToLower() == "mediumint" || dataTypes[k].ToLower() == "bit")
                        dataTypes[k] = "int";
                    if (dataTypes[k].ToLower() == "decimal")
                        dataTypes[k] = "double";
                    if (dataTypes[k].ToLower() == "enum")
                    {
                        dataTypes[k] = "string";
                    }

                    if (columnNames[k] == "class")
                        columnNames[k] = "class_var";
                        
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
                    sw.WriteLine("using MySql.Data.MySqlClient;");
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
                            if (defaultvalue.Contains(" "))
                                defaultvalue = "\"" + defaultvalue + "\"";
                        }
                        if ((dataTypes[i] == "int" || dataTypes[i] == "double") && columnDefaults[i] == "")
                            defaultvalue = "0";

                        if ((dataTypes[i] == "char" && columnDefaults[i] == "null") || (dataTypes[i] == "char" && columnDefaults[i] == ""))
                            defaultvalue = "Char.MinValue";

                        if ((dataTypes[i] == "char" && columnDefaults[i] != ""))
                            defaultvalue = "'"+columnDefaults[i]+"'";

                        if ((dataTypes[i] == "float" && columnDefaults[i] == "null") || (dataTypes[i] == "float" && columnDefaults[i] == ""))
                            defaultvalue = "0.0f";

                        if ((dataTypes[i] == "float" && columnDefaults[i] != ""))
                            defaultvalue = columnDefaults[i] + "f";

                        sw.WriteLine("\t\tpublic " + dataTypes[i] + " " + columnName + " { get; set; } = " + defaultvalue + "; //Comment: " + columnComments[i]);
                        sw.WriteLine("\t\t" + dataTypes[i] + " OLD_" + columnName + " = " + defaultvalue + ";");
                        sw.WriteLine("");
                        i++;
                    }
                    sw.WriteLine("\t\tMySqlConnection conn = new MySqlConnection(\"server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;\");");
                    sw.WriteLine("");

                    List<string> parametri = new List<string>();
                    for(int k = 0; k < columnNames.Count; k++)
                    {
                        parametri.Add(dataTypes[k] + " _" + columnNames[k]);
                    }
                    var parametristring = String.Join(", ", parametri);
                    sw.WriteLine("\t\tpublic " + UppercaseFirst(nome) + "() { }");
                    sw.WriteLine("");
                    sw.WriteLine("\t\tpublic " + UppercaseFirst(nome) + "(" + parametristring + ")");
                    sw.WriteLine("\t\t{");
                    for (int k = 0; k < parametri.Count; k++)
                    {
                        sw.WriteLine("\t\t\t" + columnNames[k] + " = _" + columnNames[k] + ";");
                    }
                    sw.WriteLine("\t\t\tupdateOldValues();");
                    sw.WriteLine("\t\t}");
                    sw.WriteLine("");
                    sw.WriteLine("\t\tpublic void delete()");
                    sw.WriteLine("\t\t{");
                    sw.WriteLine("\t\t\tconn.Open();");
                    sw.WriteLine("\t\t\tMySqlCommand cmd = new MySqlCommand(\"\", conn);");
                    List<string> whereStatementArray = new List<string>();
                    for(int k = 0; k < columnNames.Count; k++)
                    {
                        whereStatementArray.Add(columnNames[k] + " = @" + columnNames[k]);
                    }
                    var whereStatementString = String.Join(" AND ", whereStatementArray);
                    sw.WriteLine("\t\t\tcmd.CommandText = \"DELETE FROM " + nome + " WHERE " + whereStatementString + ";\";");
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tMySqlParameter " + columnNames[k].ToLower() + "Parameter = new MySqlParameter(\"@" + columnNames[k] + "\", MySqlDbType.VarChar, 0);"); //always varchar so i don't have problem to handle strings
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\t" + columnNames[k].ToLower() + "Parameter.Value = " + columnNames[k] + ";");
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
                    sw.WriteLine("\t\t\tMySqlCommand cmd = new MySqlCommand(\"\", conn);");
                    List<string> updateStatementArray = new List<string>();
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        updateStatementArray.Add(columnNames[k] + " = @new" + columnNames[k]);
                    }
                    var updateStatementString = String.Join(", ", updateStatementArray);
                    sw.WriteLine("\t\t\tcmd.CommandText = \"UPDATE " + nome + " SET " + updateStatementString + " WHERE " + whereStatementString + ";\";");
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tMySqlParameter OLD_" + columnNames[k].ToLower() + "Parameter = new MySqlParameter(\"@" + columnNames[k] + "\", MySqlDbType.VarChar, 0);");
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tMySqlParameter " + columnNames[k].ToLower() + "Parameter = new MySqlParameter(\"@new" + columnNames[k] + "\", MySqlDbType.VarChar, 0);");
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\t" + columnNames[k].ToLower() + "Parameter.Value = " + columnNames[k] + ";");
                    }
                    for (int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tOLD_" + columnNames[k].ToLower() + "Parameter.Value = OLD_" + columnNames[k] + ";");
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
                    for(int k = 0; k < columnNames.Count; k++)
                    {
                        sw.WriteLine("\t\t\tOLD_" + columnNames[k] + " = " + columnNames[k] + ";");
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
