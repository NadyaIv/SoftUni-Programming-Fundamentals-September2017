using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());
            double pricestudio = 0;
            double pricedouble = 0;
            double pricesuite = 0;
            if ( month=="May")
            {
                if (count > 7)
                {
                    pricestudio = 0.95 * count * 50;
                }
                else
                {
                    pricestudio = count * 50;
                }
                pricedouble = count * 65;
                pricesuite = count * 75;
                Console.WriteLine("Studio: {0:F2} lv.",pricestudio);
                Console.WriteLine("Double: {0:F2} lv.",pricedouble);
                Console.WriteLine("Suite: {0:F2} lv.",pricesuite);
            }
            if (month=="June")
            {
                if ( count>14)
                {
                  
                    pricedouble = 72 * 0.90 * count;
                  
                }
                else
                {
                    pricedouble = 72 * count;
                }

                pricestudio = count * 60;
                pricesuite = count * 82;
               
                Console.WriteLine("Studio: {0:F2} lv.", pricestudio);
                Console.WriteLine("Double: {0:F2} lv.", pricedouble);
                Console.WriteLine("Suite: {0:F2} lv.", pricesuite);
            }
            if (month == "July" || month == "August" || month == "December")
            {
                if ( count>14)
                {
                    pricesuite = 0.85 * count * 89;

                }
                else
                {
                    pricesuite = count * 89;
                }
                pricestudio = count * 68;
                pricedouble = count * 77;
                Console.WriteLine("Studio: {0:F2} lv.", pricestudio);
                Console.WriteLine("Double: {0:F2} lv.", pricedouble);
                Console.WriteLine("Suite: {0:F2} lv.", pricesuite);
            }

            if (month == "September" )
            {
                if (count > 7 && count<=14)
                {

                    pricestudio = 60* (count-1);
                    pricedouble = count * 72;
                    pricesuite = count * 82;

                }
                else if (count>14)
                {
                    pricestudio = 60 * (count-1);
                    pricedouble = 0.90 * 72 * count;
                    pricesuite = count * 82;
                }
                else
                {
                    pricestudio = count * 60;
                    pricedouble = count * 72;
                    pricesuite = count * 82;
                }

                

                Console.WriteLine("Studio: {0:F2} lv.", pricestudio);
                Console.WriteLine("Double: {0:F2} lv.", pricedouble);
                Console.WriteLine("Suite: {0:F2} lv.", pricesuite);
            }
            if (month == "October")
            {
                if (count >7)
                {

                    pricestudio = 0.95*50 * (count - 1);
                    
                }
                else
                {
                    pricestudio = 50 * count;
                }

                pricedouble = count * 65;
                pricesuite = count * 75;

                Console.WriteLine("Studio: {0:F2} lv.", pricestudio);
                Console.WriteLine("Double: {0:F2} lv.", pricedouble);
                Console.WriteLine("Suite: {0:F2} lv.", pricesuite);
            }
        }
    }
}
