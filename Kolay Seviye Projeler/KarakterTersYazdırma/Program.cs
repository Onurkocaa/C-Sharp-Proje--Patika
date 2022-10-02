using System;

namespace KarakterTersYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Merhaba Hello Question";
            string reverse = "";
            string character = "";
            for (int i = 0; i <= text.Length; i++)
            {
                if (i == 0)
                {
                    character = text[i].ToString();
                }
                else if (i == text.Length)
                {
                    reverse += character;
                }
                else if (text[i-1].ToString() == " ")
                {
                    continue;
                }
                else if (text[i].ToString() == " ")
                {
                    reverse += character + " ";
                    character = text[i+1].ToString();
                }
                else
                {
                    reverse += text[i].ToString();
                }
            }
            Console.WriteLine(reverse);
        }
    }
}