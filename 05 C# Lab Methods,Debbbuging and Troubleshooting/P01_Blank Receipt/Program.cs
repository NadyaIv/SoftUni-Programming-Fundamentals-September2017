using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Blank_Receipt
{
    class Program
    { static void CashReceipt(int count)
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', count));
        }
        static void Charged(int count)
        {
            Console.WriteLine("Charged to" + new string('_', count));
            Console.WriteLine("Received by" + new string('_', 19));
        }
        static void Heather(int count)
        {
            Console.WriteLine(new string('-', count));
            Console.WriteLine("© SoftUni");
        }
        static void Receipt()
        {
        CashReceipt(30);
            Charged(20);
            Heather(30);
    }


        static void Main(string[] args)
        {
            Receipt();      
        }
    }
}
