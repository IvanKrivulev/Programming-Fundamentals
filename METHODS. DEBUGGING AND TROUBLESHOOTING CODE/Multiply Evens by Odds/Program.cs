using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int result = GetMultipleOfEvensAndOdds(n);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvens(number);
            int sumOdds = GetSumOfOdds(number);
            return sumEvens * sumOdds;
        }

        static int GetSumOfOdds(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number = number / 10;
            }
            return sum;
        }

        static int GetSumOfEvens(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number = number / 10;
            }
            return sum;
        }
    }
}
