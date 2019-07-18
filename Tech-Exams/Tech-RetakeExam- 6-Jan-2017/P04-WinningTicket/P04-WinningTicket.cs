using System;
using System.Collections.Generic;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] split = new char[] { ',', ' ' };
            string[] input = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries);

            List<char> luckySymbols = new List<char> { '@', '#', '$', '^' };

            for (int index = 0; index < input.Length; index++)
            {
                string ticket = input[index];

                if (input[index].Length == 20)
                {
                    string resultLeft = CheckIfWins(ticket, luckySymbols, 0, 10);

                    if (resultLeft.Length > 5)
                    {
                        string resultRight = CheckIfWins(ticket, luckySymbols, 10, 20);

                        int matchLength = Math.Min(resultLeft.Length, resultRight.Length);

                        if (matchLength > 5 && resultLeft[0] == resultRight[0])
                        {
                            char winningChar = resultLeft[0];

                            if (matchLength > 9)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{winningChar} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{winningChar}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }

        public static string CheckIfWins(string ticket, List<char> luckySymbols, int startIndex, int endIndex)
        {
            string result = string.Empty;
            int count = 0;
            int maxCount = 0;

            for (int index = startIndex; index < endIndex; index++)
            {
                if (luckySymbols.Contains(ticket[index]))
                {
                    if (index != 0)
                    {
                        if (ticket[index - 1] != ticket[index])
                        {
                            count = 0;
                        }
                    }
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        if (maxCount > 5)
                        {
                            char winningChar = ticket[index];
                            result = new string(winningChar, maxCount);
                        }
                    }
                }
            }

            return result;
        }
    }
}
