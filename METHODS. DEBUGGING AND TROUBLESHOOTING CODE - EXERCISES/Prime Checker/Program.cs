using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        private static bool IsPrime(long number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            double sqrt = Math.Sqrt(number);

            for (int i = 2; i <= sqrt; i++)
            {
                if (number % i == 0) return false;
                
            }
            return true;
        }

    }
}
