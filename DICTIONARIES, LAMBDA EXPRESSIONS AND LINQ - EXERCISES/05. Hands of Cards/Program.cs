using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardsPoints = new Dictionary<string, int>();
            {
                cardsPoints["2"] = 2;
                cardsPoints["3"] = 3;
                cardsPoints["4"] = 4;
                cardsPoints["5"] = 5;
                cardsPoints["6"] = 6;
                cardsPoints["7"] = 7;
                cardsPoints["8"] = 8;
                cardsPoints["9"] = 9;
                cardsPoints["10"] = 10;
                cardsPoints["J"] = 11;
                cardsPoints["Q"] = 12;
                cardsPoints["K"] = 13;
                cardsPoints["A"] = 14;

            }
            
            var cardTypes = new Dictionary<string, int>();
            {
                cardTypes["S"] = 4;
                cardTypes["H"] = 3;
                cardTypes["D"] = 2;
                cardTypes["C"] = 1;
            }
            var cardScores = new Dictionary<string, List<int>>();
        }
    }
}
