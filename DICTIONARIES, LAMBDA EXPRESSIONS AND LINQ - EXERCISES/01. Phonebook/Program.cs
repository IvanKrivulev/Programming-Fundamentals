using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            var command = Console.ReadLine().Split(' ');
            //var action = command[0];

            while (command[0] != "END")
            {
                string name = command[1];

                if (command[0] == "A")
                {
                    phonebook[name] = command[2];
                }
                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        foreach (var pair in phonebook)
                        {
                            if (pair.Key == name)
                            {
                                Console.WriteLine($"{pair.Key} -> {pair.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                

                    command = Console.ReadLine().Split(' ');
            }
        }
    }
}
