using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharpRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# program that uses static Regex
            // The input string again.
            string input = "/content/alternate-1.aspx";

            // This calls the static method specified.
            Console.WriteLine(RegexUtil.MatchKey(input));
            Console.ReadKey();
        }
    }
    static class RegexUtil
    {
        static Regex _regex = new Regex(@"/content/([a-z0-9\-]+)\.aspx$");
        /// <summary>
        /// This returns the key that is matched within the input.
        /// </summary>
        static public string MatchKey(string input)
        {
            Match match = _regex.Match(input.ToLower());
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }
    }
}
