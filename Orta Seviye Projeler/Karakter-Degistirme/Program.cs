using System;

namespace Karakter_Degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string cümle = "Merhaba Hello Algoritma x";
            string[] kelime = cümle.Split();
            foreach (var item in kelime)
            {
             char[] harfler = item.ToCharArray();
             char change = harfler[0];
             harfler[0] = harfler[harfler.Length - 1];
             harfler[harfler.Length - 1] = change;

             string yenı = "";
             foreach (var news in harfler)
             yenı += news.ToString();
             Console.Write(yenı + " ");
            }
            Console.WriteLine();
        }
    }
}