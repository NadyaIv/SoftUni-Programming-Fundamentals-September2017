using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_Master_Numbers
{
    class Program
    { static bool Palindrome(int num)
        {
            bool status=false;
            int left = num;
            int rev = 0;
            while (left > 0)
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }
            if (num == rev)
            {
                status = true;
            }
            return status;
        }
        static bool DivisibleOfseven(int num)
        {
            bool status = false;
            int left = num;
            int rev = 0;
            while (left > 0)
            {
                int r = left % 10;
                rev  += r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }
            if ( rev%7==0)
            {
                status = true;
            }
            return status;
        }
        static bool OneEvenDigit(int num)
        {
            int save = 0;
            bool status=false;
            int left = num;
            int rev = 0;
            while (left > 0)
            {
                int r = left % 10;
                if (r % 2 == 0)
                {
                    status = true;
                }
                left = left / 10;  //left = Math.floor(left / 10); 
            }
            

            return status;

        }
       
       
            
            
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i <= num; i++)
            {
                if (Palindrome(i) == true && DivisibleOfseven(i) == true && OneEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }


        }
    
    }
}
