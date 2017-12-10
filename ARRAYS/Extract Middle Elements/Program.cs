using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (nums.Length == 1)
            {
                GetOne(nums);
            }
            else if (nums.Length % 2 == 0)
            {
                GetEven(nums);
            }
            else if (nums.Length % 2 != 0)
            {
                GetOdd9(nums);
            }
     
        }

        private static void GetOdd9(int[] nums)
        {
            int n = nums.Length;
            Console.WriteLine($"{{ {nums[n / 2 - 1]}, {nums[n / 2]}, {nums[n / 2 + 1]} }} ");
        }

        private static void GetEven(int[] nums)
        {
            int n = nums.Length;
            Console.WriteLine($"{{ {nums[n/2 - 1]}, {nums[n / 2]} }} ");
        }

        private static void GetOne(int[] nums)
        {
            Console.WriteLine($"{{ {nums[0]} }}");
        }
    }
}
