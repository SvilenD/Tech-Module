using System;

namespace TryCatch
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("It's a number");
            }
            catch (Exception err)   // може да е празно или определен вид грешка или.... запазва грешката в променливата err
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine(err.Message);
            }
            finally
            {
                Console.WriteLine("Изпълнява се даже и да е гръмнала програмата (или поне би трябвало)");
            }
        }
    }
}
