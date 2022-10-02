using System;

namespace Voting
{
    class Database
    {
        public static List<Person> user = new List<Person>();
        public static List<Category> category = new List<Category>();

        static Database()
        {
            user = new List<Person>()
            {
              new Person{UserName = "Onur Koca"},
              new Person{UserName = "Tevfik Zaim"},
              new Person{UserName = "Şebnem Zaim"},
            };
            category = new List<Category>()
            {
                new Category{IdCategory = 1,NameCategory ="Movie"},
                new Category{IdCategory = 2,NameCategory ="TechStack"},
                new Category{IdCategory = 3,NameCategory ="Sport"},

            };
        }
    }
}

