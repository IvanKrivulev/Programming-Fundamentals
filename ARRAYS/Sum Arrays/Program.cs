using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len1 = arrayOne.Length;
            int len2 = arrayTwo.Length;

            int longer = Math.Max(len1, len2);

            int[] sumArr = new int[longer];

            for (int i = 0; i < longer; i++)
            {
                sumArr[i] = arrayOne[i % len1] + arrayTwo[i % len2];
            }

            Console.WriteLine(string.Join(" ", sumArr));

        }
    }
}
