using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool validArtist = true;
                bool validSong = true;

                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputSplit = input.Split(':');
                var artist = inputSplit[0];
                var song = inputSplit[1];

                if (char.IsUpper(artist[0]))
                {
                    for (int i = 1; i < artist.Length; i++)
                    {
                        if (!char.IsLower(artist[i]) && artist[i] != ' ' && artist[i] != '\'')
                        {
                            validArtist = false;
                            break;
                        }
                    }
                }

                for (int i = 0; i < song.Length; i++)
                {
                    if (!char.IsUpper(song[i]) && song[i] != ' ')
                    {
                        validSong = false;
                        break;
                    }
                }

                if (validArtist && validSong)
                {
                    var result = new StringBuilder();
                    int key = artist.Length;

                    for (int i = 0; i < input.Length; i++)
                    {
                        var symbol = input[i];
                        if (symbol == ':')
                        {
                            result.Append('@');
                        }
                        else if (symbol != ' ' && symbol != '\'')
                        {
                            if (symbol <= 'Z')
                            {
                                symbol += (char)key;
                                if (symbol > 'Z')
                                {
                                    symbol -= (char)26;
                                }
                            }
                            else if (symbol >= 'a')
                            {
                                symbol += (char)key;
                                if (symbol > 'z')
                                {
                                    symbol -= (char)26;
                                }
                            }
                            result.Append(symbol);
                        }
                        else
                        {
                            result.Append(input[i]);
                        }
                    }
                    Console.WriteLine($"Successful encryption: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}