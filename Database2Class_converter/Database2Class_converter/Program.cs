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
                cmd.CommandText = "SELECT COLUMN_NAME, COLUMN_DEFAULT, IS_NULLABLE, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME= '"+nome+"' AND TABLE_SCHEMA = '"+dbname+"' ORDER BY ORDINAL_POSITION;";
                List<string> columnNames = new List<string>();
                List<string> columnDefaults = new List<string>();
                List<string> areNullables = new List<string>();
                List<string> dataTypes = new List<string>();
                row = cmd.ExecuteReader();
                while(row.Read())
                {
                    columnNames.Add(row["COLUMN_NAME"].ToString());
                    columnDefaults.Add(row["COLUMN_DEFAULT"].ToString());
                    areNullables.Add(row["IS_NULLABLE"].ToString());
                    dataTypes.Add(row["DATA_TYPE"].ToString());
                }
                row.Close();

                for (int k = 0; k < columnNames.Count; k++)
                {
                    if (dataTypes[k] == "varchar" || dataTypes[k] == "date" || dataTypes[k] == "timestamp" || dataTypes[k].ToLower() == "text" || dataTypes[k].ToLower() == "datetime")
                        dataTypes[k] = "string";
                    if (dataTypes[k].ToLower() == "tinyint" || dataTypes[k].ToLower() == "bigint")
                        dataTypes[k] = "int";
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
                        sw.WriteLine("\t\t" + dataTypes[i] + " " + columnName + " = " + defaultvalue + ";");
                        i++;
                    }
                    sw.WriteLine("");

                    List<string> parametri = new List<string>();
                    for(int k = 0; k < columnNames.Count; k++)
                    {
                        parametri.Add(dataTypes[k] + " _" + columnNames[k]);
                    }
                    var parametristring = String.Join(", ", parametri);

                    sw.WriteLine("\t\tpublic " + UppercaseFirst(nome) + "(" + parametristring + ")");
                    sw.WriteLine("\t\t{");
                    sw.WriteLine("\t\t\t");
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
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
