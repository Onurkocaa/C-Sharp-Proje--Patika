using System;

namespace Integer_İkili_Toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen gireceğiniz sayı ikililerini bir boşluk bırakarak giriniz :");
            string  sayı= Console.ReadLine();
            int toplam=0, sayılar = 0;
            string[] Dizi = sayı.Split(" ");
            sayılar = Convert.ToInt32(Dizi.Length);
            while (Dizi.Length % 2 != 0)
            {
                sayılar = Convert.ToInt32(Dizi.Length) - 1;
                Console.WriteLine("İkili olarak girmediğiniz için tek sayı adedi çıkarıldı.");
                break;
            }            
            
            for (int i = 0; i < sayılar; i+=2)
            {
                if (Dizi[i] == Dizi[i+1])
                {
                    toplam =Convert.ToInt32(Dizi[i]) + Convert.ToInt32(Dizi[i + 1]);
                    Console.Write($" {toplam*toplam} ");
                }
                else
                {
                    toplam = Convert.ToInt32(Dizi[i]) + Convert.ToInt32(Dizi[i + 1]);
                    Console.Write($" {toplam} ");
                }
            }
        }
    }
}
