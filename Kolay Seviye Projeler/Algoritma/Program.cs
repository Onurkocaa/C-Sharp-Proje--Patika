using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kelime giriniz ve virgül kullanarak sayıyı giriniz:");
            string cümle = Console.ReadLine();
            
            string[] kelime = cümle.Split(",");
            string k= kelime[0];
            Console.WriteLine(k);
        }
    }
}