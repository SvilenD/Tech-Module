using System;

namespace DiffIntegerSize2
{
    class DiffIntegerSize2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isLong = long.TryParse(input, out long longResult);
            if (isLong == false)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{input} can fit in:");

                bool isSbyte = sbyte.TryParse(input, out sbyte sbyteResult);
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }

                bool isByte = byte.TryParse(input, out byte byteResult);
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }

                bool isShort = short.TryParse(input, out short shortResult);
                if (isShort)
                {
                    Console.WriteLine("* short");
                }

                bool isUshort = ushort.TryParse(input, out ushort ushortResult);
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }

                bool isInt = int.TryParse(input, out int intResult);
                if (isInt)
                {
                    Console.WriteLine("* int");
                }

                bool isUint = uint.TryParse(input, out uint uintResult);
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }

                Console.WriteLine("* long");
            }
        }
    }
}