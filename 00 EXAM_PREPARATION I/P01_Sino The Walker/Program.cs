using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace P01_Sino_The_Walker
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] timeArrived = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            int hour = timeArrived[0];
            int minute= timeArrived[1];
            int second= timeArrived[2];
            BigInteger total = hour * 3600 + minute * 60 + second;
            BigInteger stepCount = BigInteger.Parse(Console.ReadLine());
            BigInteger secondsForAstep= BigInteger.Parse(Console.ReadLine());
            BigInteger secondsForSteps = new BigInteger();
            secondsForSteps = stepCount*secondsForAstep+total;
            BigInteger hours = (secondsForSteps/3600)%24;
            BigInteger minutes = (secondsForSteps/ 60) % 60;
            BigInteger seconds= secondsForSteps% 60;
            Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}", hours, minutes, seconds);
            
            
        }
    }
}
