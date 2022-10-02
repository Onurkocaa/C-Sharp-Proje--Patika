using System;

namespace AlanHesaplama
{
    class PerimeterCalculator
    {
        public double DaireCevre()
        {
           Console.WriteLine("Lütfen dairenin yarı çapını giriniz:");
           double yarıcap= double.Parse(Console.ReadLine());
           return 2*Math.PI*yarıcap;
        }
        public double UcgenCevre()
        {
            Console.WriteLine("Lütfen kenar uzunluğunu girin :");
            int ukenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. uzunluğunu girin :");
            int ukenar2 = int.Parse(Console.ReadLine());
            double hipotenus = Math.Sqrt((ukenar*ukenar)+(ukenar2*ukenar2));
            return ukenar+ukenar2+hipotenus;
        }
        public int DikdörtgenCevre()
        {
            Console.WriteLine("Lütfen kısa kenarı giriniz:");
            int kısakenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen uzun kenarı giriniz:");
            int uzunkenar = int.Parse(Console.ReadLine());
            return (kısakenar+uzunkenar)*2;
        }
        public int KareCevre()
        {
            Console.WriteLine("Lütfen kenar uzunluğu giriniz:");
            int karek = int.Parse(Console.ReadLine());
            return karek*4;
        }
    }
}