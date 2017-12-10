using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                int randomizedIndex = rnd.Next(0, words.Length);
                string tempWord = words[randomizedIndex];

                currentWord = tempWord;
                tempWord = currentWord;

            }


            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
