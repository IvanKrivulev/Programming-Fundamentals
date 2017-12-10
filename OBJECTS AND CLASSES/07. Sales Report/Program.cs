using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var salesDictionary = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentSale = ReadSale();

            }
        }

        static Sale ReadSale()
        {
            var input = Console.ReadLine().Split().ToArray();
            Sale item = new Sale
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };

            return item;

        }
    }
}
