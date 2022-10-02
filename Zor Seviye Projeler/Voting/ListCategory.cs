using System;

namespace Voting
{
    class ListCategory
    {
     public void ListCategor(List<Category>liste)
        {
            foreach(var item in liste)
            {
                Console.WriteLine("Başlık:"+(item.IdCategory)+" "+item.NameCategory);
            }
        }
    }
}