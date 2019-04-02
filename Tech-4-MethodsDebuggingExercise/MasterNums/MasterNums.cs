using System;
using System.Linq;
using System.Text;

class MasterNums 
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        GetMasterNum(number);
    }

    static void GetMasterNum(int num)
    {
        for (int index = 1; index <= num; index++)
        {
            if (IsPalindrome(index))
            {
                if (SumOfDigitsAreDivisible7(index))
                {
                    if (HasEvenDigit(index))
                    {
                        Console.WriteLine(index);
                    }
                }
            }
        }
    }

    static bool IsPalindrome(int num)
    {
        var numString = num.ToString();
        var reversed = new StringBuilder();
        for (int i = numString.Length - 1; i >= 0; i--)
        {
            reversed.Append(numString[i]);
        }
        if (num == int.Parse(reversed.ToString()))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    static bool SumOfDigitsAreDivisible7(int num)
    {
        bool divisible7 = false;

        int digitsSum = 0;

        while (num > 0)
        {
            digitsSum += num % 10;
            num /= 10;
        }

        if (digitsSum % 7 == 0)
        {
            divisible7 = true;
        }
        return divisible7;
    }

    static bool HasEvenDigit(int num)
    {
        bool evenDigit = false;
        int digit = 0;
        while (num > 0)
        {
            digit = num % 10;
            num /= 10;
            if (digit % 2 == 0)
            {
                evenDigit = true;
                break;
            }
        }
        return evenDigit;
    }
}