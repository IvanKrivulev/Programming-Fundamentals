using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            int nOriginal = n / 2;

            while (n >= m)
            {
                n -= m;
                count++;
                if (n == nOriginal)
                {
                    if (y >= 1)
                    {
                        n /= y;                        
                    }
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
