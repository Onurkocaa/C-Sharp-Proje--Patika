using System;

namespace AlanHesaplama
{
    class AreaCalculator
    {
        public double Daire()
        {
          Console.WriteLine("Lütfen dairenin yarıçapını giriniz :");
          double yarıcap=int.Parse(Console.ReadLine());
          return Math.PI*yarıcap*yarıcap;
        }
        public int Ucgen()
        {
            Console.WriteLine("Lütfen kenar uzunluğunu girin :");
            int ukenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. uzunluğunu girin :");
            int ukenar2 = int.Parse(Console.ReadLine());
            return (ukenar*ukenar2)/2;
        }
        public int Dikdörtgen()
        {
            Console.WriteLine("Lütfen kısa kenarı giriniz:");
            int kısakenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen uzun kenarı giriniz:");
            int uzunkenar = int.Parse(Console.ReadLine());
            return kısakenar*uzunkenar;
        }
        public int Kare()
        {
            Console.WriteLine("Lütfen kenar uzunluğu giriniz:");
            int karek = int.Parse(Console.ReadLine());
            return karek*karek;
        }
    }
}