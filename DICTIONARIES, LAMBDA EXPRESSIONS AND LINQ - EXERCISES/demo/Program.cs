using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    
    class Program
    {
        class Point
        {
            public int A { get; set; }
            public int B { get; set; }

        }
        static void Main(string[] args)
        {

           Point a = new Point {A = 5, B = 6};
           Console.WriteLine($"{a.A} {a.B}");
            
        }
    }
}
