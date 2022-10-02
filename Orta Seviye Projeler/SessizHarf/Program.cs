using System;

namespace SessizHarf
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kelime giriniz :");
            string[] sessiz = Console.ReadLine().Split();  
            Kontrol(sessiz);          
        }
        static void Kontrol(string[] sessiz)
        {
            foreach (var item in sessiz)
            {
                bool ses = false;
                for(int i=1;i<item.Length;i++)
                {
                  if(SesliHarf(item[i]) == SesliHarf(item[i-1]))
                    ses= true;  
                }
                Console.WriteLine(ses + " ");
            }
            bool SesliHarf(char a)
            {
                return !"aeıioöuüAEIİOÖUÜ".ToCharArray().Contains(a);
            }
        }
    }
}