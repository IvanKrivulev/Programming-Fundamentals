using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sortedNums = input.OrderByDescending(x => x);
            var take = sortedNums.Take(3);

            Console.WriteLine(string.Join(" ", take));
        }
    }
}
