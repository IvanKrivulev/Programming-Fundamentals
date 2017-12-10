using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            CalculateFactorial(n);
        }

        static void CalculateFactorial(int n)
        {
            BigInteger number = n;

            for (int i = n-1; i >= 1; i--)
            {
                number = number * i;
            }
            Console.WriteLine(number);
        }
    }
}
