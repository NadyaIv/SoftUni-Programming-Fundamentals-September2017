using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        { int count = 0;
            int sumdays = 0;
            string startday = Console.ReadLine();
            string endday = Console.ReadLine();
            DateTime startsday = DateTime.ParseExact(startday,"dd-MM-yyyy",CultureInfo.InvariantCulture);
            DateTime endsday = DateTime.ParseExact(endday, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            TimeSpan daysdiff =endsday.Subtract(startsday);
            int days =daysdiff.Days;
           
           
            DateTime firstJanuary = new DateTime(startsday.Year,1,1);
            DateTime thirdMarch = new DateTime(startsday.Year, 3, 3);
            DateTime firstMay = new DateTime(startsday.Year, 5, 1);
            DateTime sixMay = new DateTime(startsday.Year, 5, 6);
            DateTime twentyfourMay = new DateTime(startsday.Year, 5, 24);
            DateTime sixSept = new DateTime(startsday.Year, 9, 6);
            DateTime twentytwoSept = new DateTime(startsday.Year, 9, 22);
            DateTime firstNiov = new DateTime(startsday.Year, 11, 1);
            DateTime twentyfourDec = new DateTime(startsday.Year, 12, 24);
            DateTime twentyfiveDec = new DateTime(startsday.Year, 12, 25);
            DateTime twentysixDec = new DateTime(startsday.Year, 12, 26);
            
            for (DateTime i = startsday; i <= endsday; i=i.AddDays(1))
            {
                int n = i.Day;
                
                int m = i.Month;
                    if ((m ==firstJanuary.Month && n==firstJanuary.Day) ||
                        (m == thirdMarch.Month && n == thirdMarch.Day) ||
                        (m == firstMay.Month && n == firstMay.Day) ||
                        (m == sixMay.Month && n == sixMay.Day) ||
                        (m == twentyfourMay.Month && n == twentyfourMay.Day) ||
                        (m == sixSept.Month && n == sixSept.Day) ||
                         (m == twentytwoSept.Month && n == twentytwoSept.Day) ||
                          (m == firstNiov.Month && n == firstNiov.Day) ||
                          (m == twentyfourDec.Month && n == twentyfourDec.Day) ||
                          (m == twentyfiveDec.Month && n == twentyfiveDec.Day) ||
                          (m == twentysixDec.Month && n == twentysixDec.Day) 
                          || i.DayOfWeek==DayOfWeek.Sunday || i.DayOfWeek ==DayOfWeek.Saturday)
                    { 
                        count+=1;
                    }
                
            }
            sumdays = days+1 - count;
            Console.WriteLine(sumdays);
        }
    }
}
