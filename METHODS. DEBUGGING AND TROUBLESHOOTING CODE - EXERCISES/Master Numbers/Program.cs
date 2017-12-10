using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                bool isPolindrome = PolindromeCheck(i);
                bool sumOfDigitsBy7 = IsDivisibleBy7(i);
                bool hasEvenDigit = CheckEvenDigit(i);

                if(isPolindrome == true && sumOfDigitsBy7 == true && hasEvenDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool CheckEvenDigit(int i)
        {
            while (i > 0)
            {
                double lastDigit = i % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool IsDivisibleBy7(int i)
        {
            double sum = 0.0;

            while(i > 0)
            {
                sum += i % 10;
                i /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool PolindromeCheck(int i)
        {
            var number = i;
            var reversedNumber = 0;

            while(i > 0)
            {
                int lastDigit = i % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                i /= 10;
            }
            if (number == reversedNumber)
            {
                return true;
            }
            return false;
        }
    }
}
