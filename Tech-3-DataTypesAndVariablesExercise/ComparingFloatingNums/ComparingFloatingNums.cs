using System;

namespace ComparingFloatingNums
{
    class ComparingFloatingNums
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            double diff = Math.Abs(firstNum - secondNum);
            bool precise = false;
            if (diff < eps)
            {
                precise = true;
            }
            Console.WriteLine(precise);
        }
    }
}
