using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04_Cubic_s_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            string pattern = @"^([0-9]+)([a-zA-Z]+)([^a-zA-Z]*)$";
            Regex regex = new Regex(pattern);
            var result = new StringBuilder();
            var rrr= new StringBuilder();
            var resultmessages = new Dictionary<string, StringBuilder>();
            while (code!="Over!")
            {
                int  length = int.Parse(Console.ReadLine());

                if (regex.IsMatch(code))
                {
                    Match match = regex.Match(code);

                    string message = match.Groups[2].Value;
                    char[] messagearray = message.ToCharArray();
                    if (message.Length == length)
                    {
                        string beforeText = match.Groups[1].Value;
                        for (int i = 0; i < beforeText.Length; i++)
                        {
                            char number = beforeText[i];
                            if (Char.IsNumber(number))
                            {
                                int digit = (int)number - 48;
                                if (message.Length - 1 < digit || digit < 0)
                                {
                                    result.Append(" ");
                                }
                                else
                                {

                                    result.Append(messagearray[digit]);
                                }

                            }
                        }
                        string afterText = match.Groups[3].Value;
                        for (int i = 0; i < afterText.Length; i++)
                        {
                            char number = afterText[i];
                            if (Char.IsNumber(number))
                            {
                                int digit = (int)number - 48;
                                if (message.Length - 1 < digit || digit < 0)
                                {
                                    result.Append(" ");
                                }
                                else
                                {
                                    result.Append(messagearray[digit]);
                                }

                            }

                        }
                        Console.WriteLine(message + " == " + result);
                    }

                    result.Remove(0, result.Length);
                }
                 code = Console.ReadLine();    
            } 
        }
    }
}
