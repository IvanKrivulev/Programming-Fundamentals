using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestlength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = i;
                }
                if (length > bestlength)
                {
                    bestlength = length;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestlength + bestStart; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            
            
        }
    }
}
