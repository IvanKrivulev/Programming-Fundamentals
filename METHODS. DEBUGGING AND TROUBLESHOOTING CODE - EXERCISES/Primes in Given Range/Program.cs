using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            CheckRangeForPrimes(num1, num2);
        }

        private static void CheckRangeForPrimes(int num1, int num2)
        {
            List<int> numbers = new List<int>();

            if (num1 > num2)
            {
                Console.WriteLine("(empty list)");
                return;
            }
            if (num1 <= 1 || num2 < 0)
            {
                num1 = 2;
            }
            for (int i = num1; i <= num2; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    numbers.Add(i);
                }
            }
            Print(numbers);
        }

        private static void Print(List<int> numbers)
        {
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
