using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'р';
        int k = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
              int endIndex = jump + 1;

                if (endIndex > text.Length - i)
                {
                    endIndex = text.Length - i;
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += jump;
            }
            else
            {
                k += 1;
            }
        }
        if (k == text.Length)
        {
            Console.WriteLine("no");
        }
    }
}
