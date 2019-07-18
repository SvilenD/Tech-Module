using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_PokemonRevolution
{
    class Pokemon
    {
        public Pokemon(string name, string evolution, int index)
        {
            this.Name = name;
            this.Evolutions = new Dictionary<string, int>();
            Evolutions.Add(evolution, index);
        }
        public string Name { get; set; }

        public Dictionary<string, int> Evolutions { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonsList = new List<Pokemon>();
            int index = 0;
            int count1 = 0;
            int count2 = 0;
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "wubbalubbadubdub")
                {
                    break;
                }
                else if (input.Length == 1)
                {
                    if (pokemonsList.Any(x => x.Name == input[0]))
                    {

                        index = pokemonsList.FindIndex(x => x.Name == input[0]);
                        Console.WriteLine($"# {pokemonsList[index].Name}");
                        foreach (var evolution in pokemonsList[index].Evolutions)
                        {
                            string evolName = evolution.Key.Substring(2);
                            Console.WriteLine($"{evolName} <-> {evolution.Value}");
                        }
                    }
                }
                else
                {
                    string currentName = input[0];
                    string currentEvolution = count1.ToString() + count2.ToString() + input[1];
                    int currentIndex = int.Parse(input[2]);
                    if (pokemonsList.Any(x => x.Name == currentName))
                    {
                        index = pokemonsList.FindIndex(x => x.Name == input[0]);
                        pokemonsList[index].Evolutions.Add(currentEvolution, currentIndex);
                    }
                    else
                    {
                        var newPokemon = new Pokemon(currentName, currentEvolution, currentIndex);
                        pokemonsList.Add(newPokemon);
                    }
                }
                    count2++;
                    if (count2 > 9)
                    {
                        count2 = 0;
                        count1++;
                    }
                }

                foreach (var poke in pokemonsList)
                {
                    Console.WriteLine($"# {poke.Name}");
                    foreach (var kvp in poke.Evolutions.OrderByDescending(x => x.Value))
                    {
                        string evolName = kvp.Key.Substring(2);
                        Console.WriteLine($"{evolName} <-> {kvp.Value}");
                    }
                }
            }
        }
    }
