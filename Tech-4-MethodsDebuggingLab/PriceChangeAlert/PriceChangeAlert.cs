using System;

class PriceChangeAlert
{
    static void Main()
    {
        int pricesAmount = int.Parse(Console.ReadLine());

        double alterationLimit = double.Parse(Console.ReadLine());

        double lastPrice = double.Parse(Console.ReadLine());

        for (int index = 0; index < pricesAmount - 1; index++)
        {
            double currentPrice = double.Parse(Console.ReadLine());

            double alteration = PriceChange(lastPrice, currentPrice);

            bool bigDifference = IsDifferent(alteration, alterationLimit);

            string message = PriceAlert(currentPrice, lastPrice, alteration, bigDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    static string PriceAlert(double current, double last, double alteration, bool bigDifference)
    {
        string result = "";
        if (alteration == 0)
        {
            result = string.Format($"NO CHANGE: {current}");
        }
        else if (!bigDifference)
        {
            result = string.Format($"MINOR CHANGE: {last} to {current} ({alteration * 100:F2}%)");
        }
        else if (bigDifference && (alteration > 0))
        {
            result = string.Format($"PRICE UP: {last} to {current} ({alteration * 100:F2}%)");
        }
        else if (bigDifference && (alteration < 0))
            result = string.Format($"PRICE DOWN: {last} to {current} ({alteration * 100:F2}%)");
        return result;
    }

    static bool IsDifferent(double limit, double alteration)
    {
        if (Math.Abs(limit) >= alteration)
        {
            return true;
        }
        return false;
    }

    static double PriceChange(double last, double current)
    {
        double alteration = (current - last) / last;
        return alteration;
    }
}