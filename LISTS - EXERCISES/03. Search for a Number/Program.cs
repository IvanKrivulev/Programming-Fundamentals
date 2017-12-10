using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var takeElements = secondLine[0];
            var removeElements = secondLine[1];
            var containsElements = secondLine[2];

            numbers.Take(takeElements);
            numbers.RemoveRange(0, removeElements);

            if (numbers.Contains(containsElements))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }


        }
    }
}
