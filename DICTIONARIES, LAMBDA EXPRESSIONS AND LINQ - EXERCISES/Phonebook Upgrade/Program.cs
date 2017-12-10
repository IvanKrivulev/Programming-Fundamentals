using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //var action = command[0];

            while (command[0] != "END")
            {

                if (command[0] == "A")
                {
                    string name = command[1];
                    string phone = command[2];
                    phonebook[name] = phone;

                }
                else if (command[0] == "S")
                {
                    string name = command[1];
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
                else if (command[0] == "ListAll")
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }


                    command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
