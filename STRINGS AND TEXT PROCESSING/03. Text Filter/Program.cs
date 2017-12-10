using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
                .Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();
            foreach (var word in banWords)
            {
                if (input.Contains(word))
                {
                    input = input.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(input);
            
        }
    }
}
