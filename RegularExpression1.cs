using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression1
{
    class RegularExpression1
    {
        //C# program that uses Regex.IsMatch() method
        // <summary>
        // Test string using Regex.IsMatch static method.
        // </summary>
        static bool IsValid(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
        }
        static void Main(string[] args)
        {
            // Test the strings with the IsValid method.
            Console.WriteLine(IsValid("dotnetperls0123"));
            Console.WriteLine(IsValid("DotNetPerls"));
            Console.WriteLine(IsValid(":-)"));
            //Console.WriteLine(IsValid(null)); // Throws an exception
            Console.WriteLine(IsValid("tomandjerryluckynumbersare4and1"));
            Console.WriteLine(IsValid("i'm kavya"));


            //C# program that uses RegexOptions.IgnoreCase
            const string value = "TEST";
            // ... This ignores the case of the "TE" characters.
            if (Regex.IsMatch(value, "te..", RegexOptions.IgnoreCase))
            {
                Console.WriteLine(true);
            }

            const string value1 = "KAVYA";
            // ... This ignores the case of the "TE" characters.
            if (Regex.IsMatch(value1, "ka..", RegexOptions.IgnoreCase))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            const string value2 = "KAVYA";
            // ... This ignores the case of the "TE" characters.
            if (Regex.IsMatch(value2, "vy..", RegexOptions.IgnoreCase))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            Console.ReadKey();
        }
    }
}
