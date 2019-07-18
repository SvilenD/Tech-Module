using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (sequence.Count > 1)
            {
                var lostBattle = new List<int>();

                for (int index = 0; index < sequence.Count; index++)
                {
                    int attacker = index;
                    int target = sequence[index] % sequence.Count;

                    if (sequence.Count == lostBattle.Count + 1)
                    {
                        break;
                    }

                    else if (lostBattle.Contains(attacker))
                    {
                        continue;
                    }

                    int result = Math.Abs(attacker - target);

                    if (attacker == target)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        lostBattle.Add(attacker);
                    }

                    else if (result % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        if (!lostBattle.Contains(target))
                        {
                            lostBattle.Add(target);
                        }
                    }

                    else
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        lostBattle.Add(attacker);
                    }
                }

                lostBattle.Sort();
                lostBattle.Reverse();

                for (int i = 0; i < lostBattle.Count; i++)
                {
                    sequence.RemoveAt(lostBattle[i]);
                }
            }
        }
    }
}