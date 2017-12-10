using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(GetMax(one, two), three));
        }

        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
