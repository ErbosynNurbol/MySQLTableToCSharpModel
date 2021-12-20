using System;
using System.Collections.Generic;

namespace MySQLToCSharp.Helpers
{
    public static class TypeNameExtensions
    {
        public static string AliasOrName(this Type type)
        {
            return TypeAliases.ContainsKey(type) ?
                TypeAliases[type] : type.Name;
        }

        private static readonly Dictionary<Type, string> TypeAliases = new Dictionary<Type, string>
    {
        { typeof(byte), "byte" },
        { typeof(sbyte), "sbyte" },
        { typeof(int), "int" },
        { typeof(uint), "uint" },
        { typeof(short), "short" },
        { typeof(ushort), "ushort" },
        { typeof(long), "long" },
        { typeof(ulong), "ulong" },
        { typeof(float), "float" },
        { typeof(double), "double" },
        { typeof(char), "char" },
        { typeof(bool), "bool" },
        { typeof(object), "object" },
        { typeof(string), "string" },
        { typeof(decimal), "decimal" },
        { typeof(void), "void" },
        { typeof(byte?), "byte?" },
        { typeof(sbyte?), "sbyte?" },
        { typeof(int?), "int?" },
        { typeof(uint?), "uint?" },
        { typeof(short?), "short?" },
        { typeof(ushort?), "ushort?" },
        { typeof(long?), "long?" },
        { typeof(ulong?), "ulong?" },
        { typeof(float?), "float?" },
        { typeof(double?), "double?" },
        { typeof(char?), "char?" },
        { typeof(bool?), "bool?" },
        { typeof(decimal?), "decimal?" }
    };
    }
}
