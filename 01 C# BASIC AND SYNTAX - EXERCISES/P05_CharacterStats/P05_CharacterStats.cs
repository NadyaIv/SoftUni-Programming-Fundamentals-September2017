using System;


namespace P05_CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Health: "+"|"+ new string('|', one) + new string('.',two-one)+ "|");
            Console.WriteLine("Energy: "+ "|"+ new string('|', three) + new string('.', four - three)+ "|");

        }
    }
}
