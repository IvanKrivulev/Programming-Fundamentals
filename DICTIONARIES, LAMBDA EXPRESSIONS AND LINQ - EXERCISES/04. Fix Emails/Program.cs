using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var book = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                book[name] = email;

                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    book.Remove(name);
                }

                name = Console.ReadLine();
            }

            foreach (var pair in book)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
