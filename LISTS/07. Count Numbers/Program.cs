using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int counter = 1;
            int currentNumber = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                int nextNumber = numbers[i];

                if (nextNumber == currentNumber)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> {counter}");
                    counter = 1;
                }
                currentNumber = nextNumber;
            }

            Console.WriteLine($"{currentNumber} -> {counter}");
        }
    }
}
