using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ');
            var action = command[0];

            while (action != "Even" && action != "Odd")
            {
                int element = int.Parse(command[1]);

                if (action == "Insert")
                {
                    int index = int.Parse(command[2]);
                    inputNumbers.Insert(index, element);
                }
                else if (action == "Delete")
                {
                    inputNumbers.RemoveAll(item => item == element);
                }

                command = Console.ReadLine().Split(' ');
                action = command[0];
            }

            foreach (var number in inputNumbers)
            {
                if (action == "Odd")
                {
                    if (number % 2 != 0)
                    {
                        Console.Write(number + " ");
                    }
                }
                else if (action == "Even")
                {
                    if (number % 2 == 0)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
