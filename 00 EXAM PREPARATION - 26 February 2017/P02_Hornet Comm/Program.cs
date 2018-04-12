using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02_Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> message = new List<string>();
            List<string> broadcast = new List<string>();
            string patternMessage=@"^([0-9]+)( <-> )([0-9a-zA-Z]+)$";
            string patternBroadcast = @"^([^0-9]+)( <-> )([0-9a-zA-Z]+)$";
            Regex regexMessage = new Regex(patternMessage);
            Regex regexBroadcast = new Regex(patternBroadcast);
            while (input != "Hornet is Green")
            {
                if (regexMessage.IsMatch(input))
                {
                    Match match = regexMessage.Match(input);
                    string recipientCode = match.Groups[1].Value;
                    char[] c = recipientCode.ToCharArray();
                    Array.Reverse(c);
                    recipientCode = new string(c);
                    string result = recipientCode + " -> " + match.Groups[3].Value;
                    message.Add(result);

                }
                if (regexBroadcast.IsMatch(input))
                {
                    Match match = regexBroadcast.Match(input);
                    string messages = match.Groups[1].Value;
                    string frequance = match.Groups[3].Value;

                    string freq = "";
                    for (int i = 0; i < frequance.Length; i++)
                    {

                        if (frequance[i] >= 65 && frequance[i] <= 90)
                        {
                            freq += (char)(frequance[i] + 32);

                        }
                        else if (frequance[i] >= 97 && frequance[i] <= 122)
                        {
                            freq += (char)(frequance[i] - 32);

                        }
                        else
                        {
                            freq += frequance[i];
                        }
                    }
                  
                    string result = freq + " -> " + messages;
                    broadcast.Add(result);

                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if(broadcast.Count>0)
            {
                foreach (var item in broadcast)
                {
                    Console.WriteLine(item);
                }
            }else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (message.Count > 0)
            {
                foreach (var item in message)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
