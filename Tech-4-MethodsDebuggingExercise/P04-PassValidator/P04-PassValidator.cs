using System;

namespace P04_PassValidator
{
    class Program
    {

        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            CheckIfValid(pass);
        }

        static void CheckIfValid(string password)
        {
            bool length = (password.Length >= 6 && password.Length <= 10);
            bool lettersAndDigits = true;
            bool hasMin2Digits = false;

            int digitCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (char.IsDigit(symbol))
                {
                    digitCount++;
                    if (digitCount >= 2)
                    {
                        hasMin2Digits = true;
                    }
                }
                if (!char.IsLetterOrDigit(symbol))
                {
                    lettersAndDigits = false;
                    break;
                }
            }

            if (length && lettersAndDigits && hasMin2Digits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!length)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters ");
                }
                if (!lettersAndDigits)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!hasMin2Digits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
    }
}