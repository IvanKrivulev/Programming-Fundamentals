using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTop(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintBody(n);
            }
            PrintTop(n);
        }

        static void PrintTop(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
        
        static void PrintBody(int number)
        {
            Console.Write('-');
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        
    }
}
