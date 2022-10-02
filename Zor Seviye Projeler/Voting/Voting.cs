using System;

namespace Voting
{
    class Voting
    {
      public void Movie()
      {
        Mov:
        Console.WriteLine("Lütfen Movie kategorisine 1 ile 10 arasında bir puan veriniz :");
        int choice = int.Parse(Console.ReadLine());
        int movie =0;
        if(choice<=10 && choice>0)
        {
            movie +=choice;
            Console.WriteLine("Oyunuz başarıyla kaydedildi.Oy kullandığınız için teşekkür ederiz.");
        }
        else
        {
            Console.WriteLine("Hatalı bir değer atadınız.Lütfen tekrar deneyin");
            goto Mov;
        }
        Console.WriteLine("Toplam Oy:"+movie);
      } 
      public void TechStack()
      {
        Tec:
        Console.WriteLine("Lütfen TechStack kategorisine 1 ile 10 arasında bir puan veriniz :");
        int choice2 = int.Parse(Console.ReadLine());
        int tech =0;
        if(choice2<=10 && choice2>0)
        {
            tech +=choice2;
            Console.WriteLine("Oyunuz başarıyla kaydedildi.Oy kullandığınız için teşekkür ederiz.");
        }
        else
        {
            Console.WriteLine("Hatalı bir değer atadınız.Lütfen tekrar deneyin");
            goto Tec;
        }
        Console.WriteLine("Toplam Oy:"+tech);
      }
      public void Sport()
      {
        Spor:
        Console.WriteLine("Lütfen Movie kategorisine 1 ile 10 arasında bir puan veriniz :");
        int choice3 = int.Parse(Console.ReadLine());
        int spors =0;
        if(choice3<=10 && choice3>0)
        {
            spors +=choice3;
            Console.WriteLine("Oyunuz başarıyla kaydedildi.Oy kullandığınız için teşekkür ederiz.");
        }
        else
        {
            Console.WriteLine("Hatalı bir değer atadınız.Lütfen tekrar deneyin");
            goto Spor;
        }
        Console.WriteLine("Toplam Oy:"+spors);
      }
    }
}