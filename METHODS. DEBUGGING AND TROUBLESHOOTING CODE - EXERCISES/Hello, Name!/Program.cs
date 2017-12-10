using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
        }

        static void PrintName()
        {
            string n = Console.ReadLine();
            Console.WriteLine($"Hello, {n}!");
        }
    }
}
