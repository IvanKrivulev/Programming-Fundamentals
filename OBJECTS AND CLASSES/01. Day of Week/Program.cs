using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            var date = new DateTime(input[2], input[1], input[0]).DayOfWeek;
            Console.WriteLine(date);
            
        }
    }
}
