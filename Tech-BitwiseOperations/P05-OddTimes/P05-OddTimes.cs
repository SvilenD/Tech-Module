using System;
using System.Linq;

namespace P05_OddTimes //Given an array of positive integers in a single line joined by space (' ').
    //All numbers occur even number of times except one number which occurs odd number of times. Find the number.
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()    
                .Split()
                .Select(int.Parse)
                .ToArray();

            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result = result ^ array[i];
            }
            Console.WriteLine(result);
        }
    }
}
//1.Read an array of integers.
//2.Initialize a variable result with value 0.
//3.Iterate through all number in the array.
//4.Use XOR (^) of result and all numbers in the array.
//a.XOR of two elements is 0 if both elements are same and XOR of a number x with 0 is x
//5.Print the result.