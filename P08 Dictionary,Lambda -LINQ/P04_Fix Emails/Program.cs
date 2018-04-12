using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            Dictionary<string, string> books = new Dictionary<string, string>();

            while (name != "stop")
            {
                string mail = Console.ReadLine();
                string[] mails = mail.Split('.').Reverse().Take(1).ToArray();
                if (mails[0] != "us" && mails[0]!="uk")
                {
                    books[name] = mail;
                }
                name = Console.ReadLine();
            }
            if( name=="stop")
            {
                foreach (var item in books)
                {
                    Console.WriteLine("{0} -> {1}",item.Key,item.Value);
                }
            }

        }
    }
}
