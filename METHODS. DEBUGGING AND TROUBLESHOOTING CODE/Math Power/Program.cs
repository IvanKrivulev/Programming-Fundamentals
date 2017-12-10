using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double result = RaiseToPower(n, p);
            Console.WriteLine(result);
        }

        static double RaiseToPower(double number, double power)
        {
            double result = 1;

            for (double i = 0; i < power; i++)
            {
                result = number * result;
            }

            return result;
        }
    }
}
