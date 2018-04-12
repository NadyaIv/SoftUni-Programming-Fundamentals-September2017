using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace P01_Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long participiants= long.Parse(Console.ReadLine());
            int lapsCountPerParticiant= int.Parse(Console.ReadLine());
            int lapLength= int.Parse(Console.ReadLine());
            int capacityTrack= int.Parse(Console.ReadLine());
            decimal moneyPerKm=decimal.Parse(Console.ReadLine());
            if(participiants>=capacityTrack*days)
            {
                participiants = capacityTrack*days;
            }

            decimal money =participiants * lapsCountPerParticiant * lapLength * moneyPerKm / 1000;
            Console.WriteLine("Money raised: {0:f2}",money);
        }
    }
}
