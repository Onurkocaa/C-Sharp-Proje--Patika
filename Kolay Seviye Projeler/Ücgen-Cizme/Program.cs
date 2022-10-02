using System;

namespace Ücgen_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen üçgenin kenar uzunluğunu giriniz :");
            int kenar=int.Parse(Console.ReadLine());
            for (int i = 0; i < kenar; i++)  
            {
             for (int j = i; j < kenar; j++)  
             {
                 Console.Write(" "); 
             }
             for (int x = 0; x <= i; x++) 
             {
                 Console.Write("*");   
                 Console.Write(" "); 
             }
             Console.WriteLine();
           }
        }
    }
}
