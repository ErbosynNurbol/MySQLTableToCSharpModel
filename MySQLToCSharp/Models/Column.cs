using MySql.Data.MySqlClient;
using MySQLToCSharp.Helpers;
using System;

namespace MySQLToCSharp.Models
{
    public class Column
    {
        public string Name { get; set; }
        public string ColumnType { get; set; }
        public Column(MySqlDataReader reader)
        {
            Name = reader.GetString(1);
            ColumnType = reader.GetString(2);
        }
        public Type Type { get; set; }

        public override string ToString()
        {
            return $"public {Type.AliasOrName()} {Name.FirstCharToUpper()} {{ get; set; }}";
        }
    }
}
