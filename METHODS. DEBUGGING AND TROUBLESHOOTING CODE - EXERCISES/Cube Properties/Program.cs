using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            GetTypeValue(side, type);
        }

        static void GetTypeValue(double side, string type)
        {
            double result = 0.0;
            switch (type)
            {
                case "face":
                    result = Math.Sqrt(2 * Math.Pow(side, 2));
                    Console.WriteLine($"{result:f2}");
                    break;
                case "space":
                    result = Math.Sqrt(3 * Math.Pow(side, 2));
                    Console.WriteLine($"{result:f2}");
                    break;
                case "volume":
                    result = Math.Pow(side, 3);
                    Console.WriteLine($"{result:f2}");
                    break;
                case "area":
                    result = 6 * Math.Pow(side, 2);
                    Console.WriteLine($"{result:f2}");
                    break;
            }
        }
    }
}
