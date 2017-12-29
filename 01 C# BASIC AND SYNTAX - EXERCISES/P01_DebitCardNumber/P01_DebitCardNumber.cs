


namespace P01_DebitCardNumbernew
{
    using System;
    class Program
    {  
        static void Main(string[] args)
        {
            var firstnumber = int.Parse(Console.ReadLine());
            var secondnumber = int.Parse(Console.ReadLine());
            var thirdnumber = int.Parse(Console.ReadLine());
            var fournumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstnumber:D4} {secondnumber:D4} {thirdnumber:D4} {fournumber:D4}" );
        }
    }
}
