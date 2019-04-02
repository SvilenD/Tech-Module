using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        bool hasMatch = false;

        const char Search = 'p';

        for (int index = 0; index < text.Length; index++)
        {
            if (text[index] == Search)
            {
                hasMatch = true;

                int endIndex = count + 1;

                if (index + endIndex > text.Length)
                {
                    endIndex = text.Length - index;
                }

                string matchedString = text.Substring(index, endIndex);
                Console.WriteLine(matchedString);
                index += count;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
