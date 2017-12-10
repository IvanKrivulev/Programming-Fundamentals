using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = CalcArea(type);
            Console.WriteLine($"{area:f2}");
        }

        static double CalcArea(string type)
        {
            if(type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                return (side * height) / 2;        
            }
            else if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                return Math.Pow(side, 2);               
            }
            else if (type == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                return width * height;               
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                return Math.PI * Math.Pow(radius, 2);
            }
            return 2.0;
        }
    }
}
