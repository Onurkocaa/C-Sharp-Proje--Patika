using System;

namespace Voting
{
    class Menu
    {
        public void MenuList()
        {
          Console.WriteLine("(1)Kayıt olmak için 1'e, (2) Kayıtlı iseniz 2'e basınız :");
          string kayıtchoice = Console.ReadLine();
          if(kayıtchoice == "1")
          {
                AddPerson person = new AddPerson();
                person.AddUser();
                goto a1;
          }
          else if(kayıtchoice == "2")
          {
            goto votmenu;
          }
          votmenu:
          Console.WriteLine("Lütfen kullanıcı adınızı giriniz :");
          string users = Console.ReadLine();
          if(Database.user.Find(a=>a.UserName==users).UserName==users)
          {
            Console.WriteLine("Giriş başarıyla yapıldı.");
          }
          a1:
            ListCategory liste2 =new ListCategory();
            liste2.ListCategor(Database.category);
            Console.WriteLine("Oy vermek istediğiniz kategorinin numarasını giriniz :");
            int catechoice = int.Parse(Console.ReadLine());
            switch(catechoice)
            {
                case 1:
                Voting selection1 = new Voting();
                selection1.Movie();
                break;
                case 2:
                Voting selection2 = new Voting();
                selection2.TechStack();
                break;
                case 3:
                Voting selection3 = new Voting();
                selection3.Sport();
                break;
                default:
                break;
            }
          }
        }      
    }