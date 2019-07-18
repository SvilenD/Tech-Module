using System;
using System.Collections.Generic;
using System.Linq;

namespace OnTheWayToAnnapurna
{
    class Program
    {
        static void Main()
        {
            var storesData = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split("->");

                if (input[0] == "END")
                {
                    break;
                }

                var command = input[0];
                var store = input[1];

                if (command == "Add")
                {
                    if (storesData.ContainsKey(store) == false)
                    {
                        storesData.Add(store, new List<string>());
                    }
                    var stores = input[2].Split(',');
                    for (int i = 0; i < stores.Length; i++)
                    {
                        var item = stores[i];

                        storesData[store].Add(item);
                    }
                }
                else if (command == "Remove")
                {
                    if (storesData.ContainsKey(store))
                    {
                        storesData.Remove(store);
                    }
                }
            }

            Console.WriteLine("Stores list:");
            foreach (var store in storesData.OrderByDescending(s => s.Value.Count).ThenByDescending(s => s.Key))
            {
                Console.WriteLine($"{store.Key}");
                for (int i = 0; i < store.Value.Count; i++)
                {
                    Console.WriteLine($"<<{store.Value[i]}>>");
                }
            }
        }
    }
}