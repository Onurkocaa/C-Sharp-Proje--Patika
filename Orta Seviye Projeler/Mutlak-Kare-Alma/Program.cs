using System;

namespace Mutlak_Kare_Alma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayıları bir boşluk bırakarak giriniz : ");
            string read = Console.ReadLine();
            string[] sayılar = read.Split(" ");
            int toplam = 0, mutlak =0 , sayı, a= 0;

            for(int i=0;i<sayılar.Length;i++)
            {
               sayı =Convert.ToInt32(sayılar[i]);
               if(sayı<67)
               {
                toplam = (67-sayı)+ toplam;
               }
               else
               {
                mutlak = (int)Math.Pow(Math.Abs(sayı-67),2);
                a = mutlak + a;
               }
            }
            Console.WriteLine($"{toplam} {a}");
        }
    }
}