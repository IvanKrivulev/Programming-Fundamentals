using System;
using System.Linq;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine();

            while (command != "print")
            {
                var commandArgs = command.Split(' ').ToArray();

                switch (commandArgs[0])
                {
                    case "add":
                        inputNumbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                        break;
                    case "addMany": inputNumbers.InsertRange(int.Parse(commandArgs[1]), commandArgs.Skip(2).Select(int.Parse).ToList());
                        break;
                    case "contains":
                        var number = int.Parse(commandArgs[1]);
                        Console.WriteLine(inputNumbers.IndexOf(number));
                        break;
                    case "remove": inputNumbers.RemoveAt(int.Parse(commandArgs[1]));
                        break;
                    case "shift":
                        var shiftNumber = int.Parse(commandArgs[1]);
                        shiftNumber = shiftNumber % inputNumbers.Count;
                        var rem = inputNumbers.Take(shiftNumber).ToList();
                        inputNumbers.RemoveRange(0, shiftNumber);
                        inputNumbers.AddRange(rem);
                        break;
                    case "sumPairs":
                        for (int i = 0; i < inputNumbers.Count - 1; i++)
                        {
                            var sum = inputNumbers[i] + inputNumbers[i + 1];
                            inputNumbers[i] = sum;
                            inputNumbers.RemoveAt(i + 1);
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", inputNumbers));
        }
    }
}
