using System;

namespace Ortalama_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=1;
            int sayı;

            Console.WriteLine("Lütfen eleman sayısı giriniz :");
            sayı=int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[sayı];

            for(int i=2;i<sayı;i++)
            {
                int c= a + b;
                Console.WriteLine(c+" ");
                a=b;
                b=c;
                sayıDizisi[i]=c;
            }
             double ortalama =0;
             int sum=0;
            for(int i=0;i<sayı;i++)
            {
                sum+=sayıDizisi[i];
            }
            ortalama = sum/sayı;
            Console.WriteLine("Fibonaci dizi ortalaması:"+ortalama);
        }
    }
}