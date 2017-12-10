using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;

namespace _04.Distance_between_Points
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point firstPoint = new Point {X = firstInput[0], Y = firstInput[1]};

            var secondInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point secondPoint = new Point {X = secondInput[0], Y = secondInput[1]};

            double result = CalcDist(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");
        }

        static double CalcDist(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Abs(firstPoint.X - secondPoint.X);
            double sideB = Math.Abs(firstPoint.Y - secondPoint.Y);
            double dist = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            double result = Math.Sqrt(dist);
            return result;
        }
    }
}
