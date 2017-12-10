using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = ",;:.!()\"'/\\[] ".ToCharArray();
            var input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var word in input)
            {
                bool containsUpper = false;
                bool containsLower = false;
                bool containsSymbol = false;

                foreach (var letter in word)
                {
                    if (char.IsLower(letter)) containsLower = true;
                    if (char.IsUpper(letter)) containsUpper = true;
                    if (!char.IsLetter(letter)) containsSymbol = true;
                }

                if(containsSymbol) mixedCase.Add(word);
                else if (!containsUpper) lowerCase.Add(word);
                else if (!containsLower) upperCase.Add(word);
                else mixedCase.Add(word);
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));

        }
    }
}
