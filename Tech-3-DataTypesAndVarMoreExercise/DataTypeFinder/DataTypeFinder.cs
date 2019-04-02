using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string dataType = string.Empty;

                try
                {
                    int result = int.Parse(input);
                    dataType = "integer";
                }
                catch (Exception)
                {
                    try
                    {
                        double result = double.Parse(input);
                        dataType = "floating point";
                    }
                    catch (Exception)
                    {
                        try
                        {
                            bool result = bool.Parse(input);
                            dataType = "boolean";
                        }
                        catch (Exception)
                        {
                            try
                            {
                                char result = char.Parse(input);
                                dataType = "character";
                            }
                            catch (Exception)
                            {
                                dataType = "string";
                            }
                        }
                    }
                }
                Console.WriteLine($"{input} is {dataType} type");
            }
        }
    }
}
