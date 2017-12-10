using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("1");
                return;
            }
            if (number == 0)
            {
                Console.WriteLine("1");
                return;
            }

            Console.WriteLine(GetFib(number));
        }

        static int GetFib(int num)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 0;

            for (int i = 0; i < num; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
            return num3;
        }
    }
}
