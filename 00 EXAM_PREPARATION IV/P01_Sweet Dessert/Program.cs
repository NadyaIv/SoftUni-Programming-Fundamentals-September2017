using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            long people = long.Parse(Console.ReadLine());
            double pricePerOneBanana = double.Parse(Console.ReadLine());
            double pricePerOneEgg = double.Parse(Console.ReadLine());
            double pricePerOneKgFruit = double.Parse(Console.ReadLine());
            double piecies = Math.Ceiling(people * 1.0 / 6) ;
            double priceAll = piecies * (2 * pricePerOneBanana + 4 * pricePerOneEgg + 0.2 * pricePerOneKgFruit);
            if(priceAll<=money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {priceAll:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(priceAll-money):f2}lv more."); 
            }
        }
    }
}
