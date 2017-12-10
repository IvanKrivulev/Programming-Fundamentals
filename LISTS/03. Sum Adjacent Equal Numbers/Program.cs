using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            bool hasSummed = true;

            while (hasSummed)
            {
                hasSummed = false;

                decimal sum = 0;
                int index = 0;

                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i] == input[i - 1])
                    {
                        index = i - 1;
                        sum += input[i] + input[i - 1];
                        hasSummed = true;
                        break;
                    }
                }

                if (hasSummed)
                {
                    input.RemoveRange(index, 2);
                    input.Insert(index, sum);
                }

                
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
