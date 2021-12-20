using System.Text.RegularExpressions;
namespace MySQLToCSharp.Helpers
{
    public class RegexHelper
    {
        static public bool IsIP(string ip)
        {
            string Pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            Regex check = new Regex(Pattern);
            if (string.IsNullOrEmpty(ip))
                return false;
            else
                return check.IsMatch(ip, 0);
        }
    }
}
