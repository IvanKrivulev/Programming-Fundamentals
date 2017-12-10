using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match m in matches)
            {
                Console.WriteLine($"{m} ");
            }
            Console.WriteLine();

        }
            
    }
}
