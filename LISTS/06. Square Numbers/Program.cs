﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> square = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == (int) Math.Sqrt(input[i]))
                {
                    square.Add(input[i]);
                }
            }

            square.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", square));
        }
    }
}
