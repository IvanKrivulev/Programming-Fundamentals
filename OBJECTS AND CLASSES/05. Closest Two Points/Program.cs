using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
            int numberOfPoints = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();

            for (int i = 0; i < numberOfPoints; i++)
            {
                var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                points.Add(new Point{X = input[0], Y = input[1]});
            }

            double minDistSoFar = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var dist = CalcDist(firstPoint, secondPoint);

                    if (dist < minDistSoFar)
                    {
                        minDistSoFar = dist;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistSoFar:f3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y}");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y}");
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
