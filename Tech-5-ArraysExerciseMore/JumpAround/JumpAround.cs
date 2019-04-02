using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int sum = 0;
        int move = 0;
        
        while (true)
        {
            if (move + input[move] >= 0 && move + input[move] < input.Length)
            {
                move += input[move];
                sum += input[move];
            }
            else if (move - input[move] >= 0 && move - input[move] < input.Length)
            {
                move -= input[move];
                sum += input[move];
            }
            else break;
        }
        sum += input[0];
        Console.WriteLine(sum);
    }
}
