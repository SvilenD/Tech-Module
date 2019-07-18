using System;

namespace P06_TriBitSwitch  //Write a program that inverts the 3 bits from position p to the left with their opposites
                            //(e.g. 111 -> 000, 101 -> 010) in 32-bit number. Print the resulting number on the console.
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int psn = int.Parse(Console.ReadLine());

            int mask = 7; // 111 binary = 7 decimal
            mask = mask << psn; //shifting 111 to the given psn

            int result = num ^ mask;

            Console.WriteLine(result);
        }
    }
}