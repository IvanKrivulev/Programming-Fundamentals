using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] {' ', '.', ',', '!', '?'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palindromes = new List<string>();

            foreach (var word in input)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(x => x)));
        }

        private static bool IsPalindrome(string word)
        {
            var reversed = new string(word.Reverse().ToArray());
            return word == reversed;
        }
    }
}
