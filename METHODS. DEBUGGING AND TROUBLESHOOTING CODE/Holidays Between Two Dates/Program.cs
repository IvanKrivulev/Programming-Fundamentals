﻿using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double prices = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double c = double.Parse(Console.ReadLine());
            double div = Proc(prices, c);
            bool isSignificantDifference = imaliDif(div, threshold);
            string message = Get(c, prices, div, isSignificantDifference);
            Console.WriteLine(message);

            prices = c;
        }
    }

    private static string Get(double c, double prices, double difference, bool etherTrueOrFalse)
    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", c);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", prices, c, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", prices, c, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", prices, c, difference);
        return to;
    }
    private static bool imaliDif(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}


