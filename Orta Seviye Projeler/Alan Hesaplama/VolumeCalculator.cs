using System;

namespace AlanHesaplama
{
    class VolumeCalculator
    {
        public string DaireHacmi()
        {
           string ab="Dairenin üç boyutlu olmadığı için hacmi olmaz!";
           return ab;
        }
        public double UcgenHacmi()
        {
            Console.WriteLine("Lütfen dik kenar uzunluğunu girin :");
            int dikkenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen yan kenar uzunluğunu girin :");
            int yankenar = int.Parse(Console.ReadLine());
            return (dikkenar*yankenar)/2;
        }
        public int DikdörtgenHacmi()
        {
            Console.WriteLine("Lütfen kısa kenarı giriniz:");
            int kısakenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen uzun kenarı giriniz:");
            int uzunkenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen yüksekliği giriniz :");
            int yükseklik = int.Parse(Console.ReadLine());
            return kısakenar*uzunkenar*yükseklik;
        }
        public int KareHacmi()
        {
            Console.WriteLine("Lütfen kenar uzunluğu giriniz:");
            int karek = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen yüksekliği giriniz:");
            int kareh = int.Parse(Console.ReadLine());
            return karek*karek*kareh;
        }
    }
}