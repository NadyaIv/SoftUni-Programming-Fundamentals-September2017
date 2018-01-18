

using System;
namespace P07_CakeIngredients
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (int i = 0; i < 1;)
            {
                var integr = Console.ReadLine();
                if (integr == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", count);
                    break;
                }
                else
                {
                    count++;
                    Console.WriteLine("Adding ingredient {0}.", integr);
                }
            }
        }
    }
}
