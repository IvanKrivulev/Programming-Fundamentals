using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            foreach (var number in input)
            {
                int reversed = ReverseNumber(number);
                sum += reversed;
            }
            Console.WriteLine(sum);
        }

        private static int ReverseNumber(int number)
        {
            int reversedNumber = 0;

            while (number > 0)
            {
                reversedNumber = (reversedNumber * 10) + (number % 10);
                number /= 10;
            }
            return reversedNumber;
        }
    }
}
