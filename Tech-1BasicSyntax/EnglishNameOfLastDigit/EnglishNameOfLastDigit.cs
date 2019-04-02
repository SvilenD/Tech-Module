using System;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int lastDigit = number % 10;
            string output = string.Empty;

            switch (lastDigit)
            {
                case 0: output = "zero"; break;
                case 1: output = "one"; break;
                case 2: output = "two"; break;
                case 3: output = "three"; break;
                case 4: output = "four"; break;
                case 5: output = "five"; break;
                case 6: output = "six"; break;
                case 7: output = "seven"; break;
                case 8: output = "eigth"; break;
                case 9: output = "nine"; break;
            }
            Console.WriteLine(output);
        }
    }
}
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int num = int.Parse(Console.ReadLine());

//        int lastDigit = num % 10;

//        var digitsAsWord = new Dictionary<int, string>()
//        {
//            {0, "zero"},{1,"one"},{2,"two"},{3,"three"},{4,"four"},
//            {5,"five"},{6,"six"},{7,"seven"},{8,"eight"},{9,"nine"},
//        };
//        Console.WriteLine(digitsAsWord[lastDigit]);
//    }
//}