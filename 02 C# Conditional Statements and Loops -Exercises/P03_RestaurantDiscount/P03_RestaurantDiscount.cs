using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var hall = "";
            double discount=0;
            double price1 = 0;
            double price = 0;
            if ( people<=50 && people >0)
            {
                hall = "Small Hall";
                price1 = 2500;
                if (package == "Normal")
                {
                    discount = 0.05;
                    price = 500;
                }
                if (package == "Gold")
                {
                    discount = 0.10;
                    price = 750;
                }
                if (package == "Platinum")
                {
                    discount = 0.15;
                    price = 1000;
                }
                price = (1 - discount) * (price + price1);
                var priceperson = price / people;
                Console.WriteLine("We can offer you the {0}", hall);
                Console.WriteLine("The price per person is {0:F2}$", priceperson);
            }
            if (people<=100 && people>50)
            {
                hall = "Terrace";
                price1 = 5000;
                if (package == "Normal")
                {
                    discount = 0.05;
                    price = 500;
                }
                else if (package == "Gold")
                {
                    discount = 0.10;
                    price = 750;
                }
                else if (package == "Platinum")
                {
                    discount = 0.15;
                    price = 1000;
                }
                price = (1 - discount) * (price + price1);
                var priceperson = price / people;
                Console.WriteLine("We can offer you the {0}", hall);
                Console.WriteLine("The price per person is {0:F2}$", priceperson);

            }
            if (people > 100 && people <= 120)
            {
                hall = "Great Hall";
                price1 = 7500;
                if (package == "Normal")
                {
                    discount = 0.05;
                    price = 500;
                }
                if (package == "Gold")
                {
                    discount = 0.10;
                    price = 750;
                }
                if (package == "Platinum")
                {
                    discount = 0.15;
                    price = 1000;
                }
                price = (1 - discount) * (price + price1);
                var priceperson = price / people;
                Console.WriteLine("We can offer you the {0}", hall);
                Console.WriteLine("The price per person is {0:F2}$", priceperson);

            }
            if (people > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
