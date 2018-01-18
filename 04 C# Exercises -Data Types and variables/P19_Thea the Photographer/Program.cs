using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            ulong secFilter= ulong.Parse(Console.ReadLine());
            ulong percent = ulong.Parse(Console.ReadLine());
            ulong secUpload = ulong.Parse(Console.ReadLine());
            ulong BroiFilter =(ulong)(Math.Ceiling(number * percent/ 100d));
            ulong BroiSecundaFilter = number* secFilter;
            ulong BroisecUpload = BroiFilter * secUpload;
            ulong allsec =BroisecUpload + BroiSecundaFilter;
           long d = (long)(allsec / 86400);
            ulong hours = (ulong)((allsec - (ulong)(d*86400))/3600d);
            ulong min =(ulong) ((allsec - (ulong)(d * 86400) - (ulong)(hours * 3600) )/ 60);
            ulong sec = (ulong)(allsec -(double)(d*86400)-(double)(hours*3600)-(ulong)(min*60));
            Console.WriteLine($"{d}:{hours:D2}:{min:D2}:{sec:D2}");
        }
    }
}
