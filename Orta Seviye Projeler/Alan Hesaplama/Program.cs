using System;

namespace AlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu:
            Console.WriteLine("***** Hoşgeldiniz!Lütfen yapacağınız işlemi seçiniz. *****");
            Console.WriteLine("(1)Çevre Hesaplama ");
            Console.WriteLine("(2)Alan Hesaplama ");
            Console.WriteLine("(3)Hacim Hesaplama ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1" :
                PerimeterCalculator cevre = new PerimeterCalculator();
                p:
                Console.WriteLine("Lütfen çevresini hesaplamak istediğiniz geometrik şekili seçiniz.");
                Console.WriteLine("(1)Daire,(2)Üçgen,(3)Dikdörtgen,(4)Kare    :");
                string secım=Console.ReadLine();
                if(secım == "1")
                {
                    Console.WriteLine(cevre.DaireCevre());
                    break;
                }
                else if(secım =="2")
                {
                    Console.WriteLine(cevre.UcgenCevre());
                    break;
                }
                else if (secım =="3")
                {
                    Console.WriteLine(cevre.DikdörtgenCevre());
                    break;
                }
                else if (secım =="4")
                {
                    Console.WriteLine(cevre.KareCevre());
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış tuşlama yaptınız.(1)Menuye dönmek için 1'e,(2)Ana Menu için 2'e.");
                    string cevrech = Console.ReadLine();
                    if(cevrech == "1")
                    {
                        goto p;
                    }
                    else if(cevrech == "2")
                    {
                        goto Menu;
                    }
                }
                break;

                case "2" :
                AreaCalculator alan = new AreaCalculator();
                a:
                Console.WriteLine("Lütfen alanını hesaplamak istediğiniz geometrik şekili seçiniz.");
                Console.WriteLine("(1)Daire,(2)Üçgen,(3)Dikdörtgen,(4)Kare    :");
                string secım2=Console.ReadLine();
                if(secım2 == "1")
                {
                    Console.WriteLine(alan.Daire());
                    break;
                }
                else if(secım2 =="2")
                {
                    Console.WriteLine(alan.Ucgen());
                    break;
                }
                else if (secım2 =="3")
                {
                    Console.WriteLine(alan.Dikdörtgen());
                    break;
                }
                else if (secım2 =="4")
                {
                    Console.WriteLine(alan.Kare());
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış tuşlama yaptınız.(1)Menuye dönmek için 1'e,(2)Ana Menu için 2'e.");
                    string alanch = Console.ReadLine();
                    if(alanch == "1")
                    {
                        goto a;
                    }
                    else if(alanch == "2")
                    {
                        goto Menu;
                    }
                }
                break;

                case "3" :
                VolumeCalculator hacim = new VolumeCalculator();
                h:
                Console.WriteLine("Lütfen hacmini hesaplamak istediğiniz geometrik şekili seçiniz.");
                Console.WriteLine("(1)Daire,(2)Üçgen,(3)Dikdörtgen,(4)Kare    :");
                string secım3=Console.ReadLine();
                if(secım3 == "1")
                {
                    Console.WriteLine(hacim.DaireHacmi());
                    break;
                }
                else if(secım3 =="2")
                {
                    Console.WriteLine(hacim.UcgenHacmi());
                    break;
                }
                else if (secım3 =="3")
                {
                    Console.WriteLine(hacim.DikdörtgenHacmi());
                    break;
                }
                else if (secım3 =="4")
                {
                    Console.WriteLine(hacim.KareHacmi());
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış tuşlama yaptınız.(1)Menuye dönmek için 1'e,(2)Ana Menu için 2'e.");
                    string hacimch = Console.ReadLine();
                    if(hacimch == "1")
                    {
                        goto h;
                    }
                    else if(hacimch == "2")
                    {
                        goto Menu;
                    }
                }
                break;
                default:
                break;
            }
        }
    }
}