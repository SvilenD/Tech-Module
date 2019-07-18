using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P04_AnonymousCache
{
    class DataSet
    {
        public DataSet(string name)
        {
            this.Name = name;
            this.Keys = new Dictionary<string, long>();
        }

        public string Name { get; set; }

        public Dictionary<string, long> Keys { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<DataSet>();

            var cache = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ', '>', '-', '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "thetinggoesskrra")
                {
                    break;
                }
                else if (input.Length == 1)
                {
                    string name = input[0];
                    if (!data.Any(x => x.Name == name))
                    {
                        var newDataSet = new DataSet(name);
                        data.Add(newDataSet);
                    }
                    while (cache.ContainsKey(name))
                    {
                        int dataIndex = data.FindIndex(x => x.Name == name);
                        var keysToAdd = cache.FirstOrDefault(x => x.Key == name).Value;
                        foreach (var kvp in keysToAdd)
                        {
                            data[dataIndex].Keys.Add(kvp.Key, kvp.Value);
                        }
                        cache.Remove(name);
                    }
                }
                else
                {
                    string key = input[0];
                    long size = long.Parse(input[1]);
                    string dataSetName = input[2];
                    if (data.Any(x => x.Name == dataSetName))
                    {
                        int dataSetIndex = data.FindIndex(x => x.Name == dataSetName);
                        data[dataSetIndex].Keys.Add(key, size);
                    }
                    else if (!cache.ContainsKey(dataSetName))
                    {
                        cache.Add(dataSetName, new Dictionary<string, long>());
                        cache[dataSetName].Add(key, size);
                    }
                    else
                    {
                        cache[dataSetName].Add(key, size);
                    }
                }
            }

            if (data.Count > 0)
            {
                PrintResult(data);
            }
        }

        static void PrintResult(List<DataSet> data)
        {
            BigInteger maxSum = 0;
            string setName = string.Empty;
            foreach (var set in data)
            {
                BigInteger sum = set.Keys.Values.Sum();
                if (sum > maxSum)
                {
                    maxSum = sum;
                    setName = set.Name;
                }
            }
            Console.WriteLine($"Data Set: {setName}, Total Size: {maxSum}");
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Name == setName)
                {
                    foreach (var kvp in data[i].Keys)
                    {
                        Console.WriteLine($"$.{kvp.Key}");
                    }
                    return;
                }
            }
        }
    }
}