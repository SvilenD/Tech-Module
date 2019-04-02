using System;
using System.Numerics;

namespace CenturieToNanosec
{
    class CenturieToNanosec
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ushort years = Convert.ToUInt16(100 * centuries);
            uint days = (uint)(365.2422 * years);
            uint hours = 24 * days;
            ulong minutes = 60 * hours;
            ulong seconds = 60 * minutes;
            ulong miliSeconds = 1000 * seconds;
            ulong microSeconds = 1000 * miliSeconds;
            BigInteger nanoSeconds = 1000 * microSeconds;    //add using System.Numerics;       //decimal nanoSeconds = 1000m * microSeconds;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} " +
                $"seconds = {miliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");
        }
    }
}