using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool tripleCheck = false;

            for (int indexer = 0; indexer < numbers.Length; indexer++)
            {
                int a = numbers[indexer];

                for (int digit = indexer + 1; digit < numbers.Length; digit++)
                {
                    int b = numbers[digit];

                    int sum = a + b;

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        tripleCheck = true;
                    }
                }
            }
            if (tripleCheck == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
