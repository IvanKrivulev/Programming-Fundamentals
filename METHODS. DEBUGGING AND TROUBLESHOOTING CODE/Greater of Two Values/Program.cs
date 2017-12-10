using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = Console.ReadLine();

            if (format == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = GetMax(a, b);
                Console.WriteLine(c);
            }

            else if (format == "char") 
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char c = GetMax(a, b);
                Console.WriteLine(c);
            }

            else if (format == "string") 
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string c = GetMax(a, b);
                Console.WriteLine(c);
            }
        }

        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }

        static string GetMax(string first, string second)
        {
            int c = string.Compare(first, second);

            if (c >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
