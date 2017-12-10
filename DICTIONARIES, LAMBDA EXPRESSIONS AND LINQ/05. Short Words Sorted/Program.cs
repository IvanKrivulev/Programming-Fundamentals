using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(new[] {' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var output = input
                .Distinct()
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(string.Join(", ", output));

        }
    }
}
