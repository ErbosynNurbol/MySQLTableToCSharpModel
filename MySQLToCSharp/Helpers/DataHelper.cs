using MySql.Data.MySqlClient;
using MySQLToCSharp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLToCSharp.Helpers
{
    public class DataHelper
    {
        public static void TableSaveToCSFile()
        {
             var connectionString = $"Server={Properties.Settings.Default.IP};port={Properties.Settings.Default.Port};database={Properties.Settings.Default.Database};uid={Properties.Settings.Default.UID};pwd={Properties.Settings.Default.Password};charset={Properties.Settings.Default.Charset};";
            var database = new Dictionary<string, List<Column>>();

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"SELECT TABLE_NAME, COLUMN_NAME, COLUMN_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '{Properties.Settings.Default.Database}'";
                    var reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                        return;

                    while (reader.Read())
                        if (database.ContainsKey(reader.GetString(0)))
                            database[reader.GetString(0)].Add(new Column(reader));
                        else
                            database.Add(reader.GetString(0), new List<Column>() { new Column(reader) });
                }
                con.Close();
            }
            foreach (var table in database)
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (var cmd = con.CreateCommand())
                    {
                        // TODO: Is there a way to do this without this senseless statement?
                        cmd.CommandText = $"SELECT * FROM `{table.Key}` LIMIT 0";
                        var reader = cmd.ExecuteReader();
                        var schema = reader.GetSchemaTable();
                        foreach (var column in table.Value)
                            column.Type = schema.Select($"ColumnName = '{column.Name}'")[0]["DataType"] as Type ?? default!;
                    }
                    con.Close();
                }
            }
            DbToClasses(database);
        }

            private static void DbToClasses(Dictionary<string, List<Column>> db)
            {
                if (!Directory.Exists(Properties.Settings.Default.SaveFolder))
                    Directory.CreateDirectory(Properties.Settings.Default.SaveFolder);

                var sb = new StringBuilder();
                foreach (var table in db)
                {
                sb.AppendLine($"using System;");
                sb.AppendLine($"using System.Collections.Generic;");
                sb.AppendLine($"namespace {Properties.Settings.Default.ModelNamespace}");
                sb.AppendLine("{");
                sb.AppendLine($"    public partial class {table.Key.FirstCharToUpper()}");
                    sb.AppendLine("    {");
                    foreach (var column in table.Value)
                        sb.AppendLine("        "+column.ToString());
                sb.AppendLine("    }");
                sb.AppendLine("}");
                var sw = new StreamWriter($"{Properties.Settings.Default.SaveFolder}/{table.Key.FirstCharToUpper()}.cs", false);
                    sw.Write(sb.ToString());
                    sw.Close();
                    sb.Clear();
                }
            }
    }
}
