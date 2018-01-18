

namespace P10_Centuries_to_Nanoseconds
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            int vec = int.Parse(Console.ReadLine());
            int years = 100 * vec;
            int days = (int)(365.2422 * years);
            long hours = 24*days;
            long minutes = 60*hours;
            long seconds = 60*minutes;
            long milliseconds = 1000*seconds;
            BigInteger microseconds =1000 * milliseconds;
            BigInteger nanoseconds = microseconds*1000;
            Console.WriteLine(vec+" centuries = "+years+" years = "+days+" days = "+hours+" hours = "+minutes+" minutes = "+seconds+" seconds = "
                +milliseconds+" milliseconds = "+microseconds+" microseconds = "+nanoseconds+" nanoseconds");
        }
    }
}
