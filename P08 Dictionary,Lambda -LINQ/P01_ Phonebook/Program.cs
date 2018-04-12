using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01__Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] phonebook = Console.ReadLine().Split().ToArray();
            Dictionary<string, string> phone = new Dictionary<string, string>();
            while(true)
            {  if (phonebook[0] =="A")
                {
                    string[] phone1 = phonebook.Skip(1).ToArray();
                    foreach (var name in phone1)
                    {
                        phone[name] = phonebook[2];

                    }
                }
                if (phonebook[0] == "S")
                {
                    if(phone.ContainsKey(phonebook[1]))
                    {
                 
                            Console.WriteLine("{0} -> {1}", phonebook[1],phone[phonebook[1]]);
                        
                     }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", phonebook[1]);
                    }
                      
                }
                if (phonebook[0] == "END")
                {
                    break;
                }
                phonebook = Console.ReadLine().Split().ToArray();
            }

        }
    }
}
