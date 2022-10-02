using System;

namespace Voting
{
    class AddPerson:Database
    {
        public void AddUser()
        {
            deneme:
            Person newuser = new Person();
            Console.WriteLine("Hoşgeldiniz!");
            Console.WriteLine("Kullanıcı adınızı giriniz :");
            string kayıt = Console.ReadLine();
            Database.user.Add(newuser);
            Console.WriteLine("Kaydınız başarıyla gerçekleşmiştir.");
        }
    }
}