using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position1
{
    class Program
    {
        class Rectangle
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Right { get { return Left + Width; } }
            public int Bottom { get { return Top + Height; } }
        }
        static void Main(string[] args)
        {
            var first = ReadRect();
            var second = ReadRect();
            

            bool result = FirstInsideSecondCheck(first, second);

            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        static Rectangle ReadRect()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rectangle = new Rectangle
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]               
            };
            return rectangle;
        }
        static bool FirstInsideSecondCheck(
            Rectangle first, Rectangle second)
        {
            bool testOne = first.Left >= second.Left;
            bool testTwo = first.Right <= second.Right;
            bool testThree = first.Top <= second.Top;
            bool testFour = first.Bottom <= second.Bottom;

            return testOne && testTwo && testThree && testFour;
        }
    }
}
