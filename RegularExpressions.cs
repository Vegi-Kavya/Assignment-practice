using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //C# program that uses Match,Regex
            Regex regex = new Regex(@"\d+");
            Match Match = regex.Match("a55a");
            if (Match.Success)
            {
                Console.WriteLine("Match value is:" + Match.Value);
            }

            Regex regex1 = new Regex(@"\d+");
            Match Match1 = regex.Match("tom9jerry");
            if (Match1.Success)
            {
                Console.WriteLine("Match value is:" + Match1.Value);
            }

            //C# program that uses Regex.Match
            // Part 1: the input string.
            string input = "/content/alternate-1.aspx";
            // Part 2: call Regex.Match.
            Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
                RegexOptions.IgnoreCase);
            // Part 3: check the Match for Success.
            if (match.Success)
            {
                // Part 4: get the Group value and display it.
                string key = match.Groups[1].Value;
            }

            string input3 = "/content/alternate-1.aspx";
            Match Mch = Regex.Match(input3,@"content/([a-zA-Z0-9\-]+)\.aspx$",RegexOptions.IgnoreCase);
            if (Match.Success)
            {
                //get the group value and display it
                string key1 = Mch.Groups[1].Value;
                Console.WriteLine(key1);
            }

            //C# program that uses IsMatch,start and end
            string test = "xxyy";

            // Match the start of a string.
            if (Regex.IsMatch(test, "^xx"))
            {
                Console.WriteLine("START MATCHES");
            }

            // Match the end of a string.
            if (Regex.IsMatch(test, "yy$"))
            {
                Console.WriteLine("END MATCHES");
            }

            string test1 = "kkjj";
            //match start of string
            if (Regex.IsMatch(test1, "^kk"))
            {
                Console.WriteLine("Start matches");
            }
            //matches end of the string
            if (Regex.IsMatch(test1, "jj$"))
            {
                Console.WriteLine("End matches");
            }

            //C# program using NextMatch
            string value = "4 AND 5";
            // Step 1: get first match.
            Match match3 = Regex.Match(value, @"\d");
            if (match3.Success)
            {
                Console.WriteLine(match3.Value);
            }
            // Step 2: get second match.
            match3 = match3.NextMatch();
            if (match3.Success)
            {
                Console.WriteLine(match3.Value);
            }

            string value1 = "74 and 93";
            //get first match
            Match match2 = Regex.Match(value1, @"\d+");
            if (match2.Success)
            {
                Console.WriteLine(match2.Value);
            }
            //get second match
            match2 = match2.NextMatch();
            if (match2.Success)
            {
                Console.WriteLine(match2.Value);
            }

            //C# program using Replace and Replace with pattern
            // Replace 2 or more digit pattern with a string.
            
            string result = regex.Replace("cat 123 456", "bird");
            Console.WriteLine("RESULT: {0}", result);

            //replace 2 or more digit patterns with a string
            string result2 = regex.Replace("tom 123 456", "bird");
            Console.WriteLine("Result is: " + result2);

            //C# program that uses non greedy regex
            string test3 = "/bird/cat/";
            // Version 1: use lazy (or non-greedy) metacharacter.
            var result4 = Regex.Match(test3, "^/.*?/");
            if (result4.Success)
            {
                Console.WriteLine("NON-GREEDY: {0}", result4.Value);
            }
            // Version 2: default Regex.
            var result5 = Regex.Match(test3, "^/.*/");
            if (result5.Success)
            {
                Console.WriteLine("GREEDY: {0}", result5.Value);
            }

            string Test = "/tom/jerry/";
            var result1 = Regex.Match(Test, "^/.*?/");
            if (result1.Success)
            {
                Console.WriteLine("Non-Greedy: {0}", result1.Value);
            }
            var result3 = Regex.Match(Test, "^/.*/");
            if (result1.Success)
            {
                Console.WriteLine("Greedy: {0}", result3.Value);
            }

            Console.ReadKey();
        }
    }
}
