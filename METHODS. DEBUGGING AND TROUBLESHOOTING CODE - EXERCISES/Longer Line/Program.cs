using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lineA = CalcLenght(x1, y1, x2, y2);
            double lineB = CalcLenght(x3, y3 ,x4 ,y4);

            if(lineA >= lineB && CheckCloserPoint(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (lineA >= lineB && CheckCloserPoint(x1, y1, x2, y2) == false)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else if (lineB >= lineA && CheckCloserPoint(x3, y3, x4, y4))
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else if (lineB >= lineA && CheckCloserPoint(x3, y3, x4, y4) == false)
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }

        }

        static double CalcLenght(double x1, double y1, double x2, double y2)
        {
            double lineLenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return lineLenght;
        }

        static bool CheckCloserPoint(double x1, double y1, double x2, double y2)
        {
            bool isCloserToZero = false;
            double c1 = Math.Abs(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double c2 = Math.Abs(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (c1 <= c2)
            {
                isCloserToZero = true;
            }
            return isCloserToZero;
        }

    }
}
