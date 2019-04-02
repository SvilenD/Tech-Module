using System;

namespace UserPass
{
    class UserPass
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            for (int i = 0; i < userName.Length; i++)
            {
                password += userName[userName.Length -1 - i];
            }
            int count = 1;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User { userName} logged in.");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                count++;
                if (count == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
            }
        }
    }
}