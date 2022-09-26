using Book_Data;
using Book_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_AppMain
{
    public class AddBooks
    {
        public void addbook() {
        var book1 = new Book()
        {
            Name = "c#",
            Countr=4,
            Price = 500,
            Description = "FrontEnd"
        };
        var book2 = new Book()
        {
            Name = "c++",
            Countr = 12,
            Price = 300,
            Description = "variable"
        };
        var book3 = new Book()
        {
            Name = "Python",
            Countr = 15,
            Price = 700,
            Description = "BackEnd"

        };
            var Context = new BookDbContext();
            
                Context.Books.Add(book3);
                Context.Books.Add(book2);
                Context.Books.Add(book1);
               // Context.SaveChanges();
            
        }
        public void getbook()
        {
            var Context = new BookDbContext();
            var books = Context.Books
     .Select(x => new {  x.Name, x.Price, x.Description });
            Console.WriteLine("Insert 1 or 2 or 3 or 4");
            string info = Console.ReadLine();

            if (info == "1")
            {
                foreach (var item in books)
                {
                    Console.WriteLine("Id = " + item.Name);
                }
            }
            else if (info == "2")
            {
                foreach (var item in books)
                {
                    Console.WriteLine("Id = "
                       + item.Name + " , "
                       + item.Price + " , "
                       + item.Description);
                }
            }
            else if (info == "3")
            {
                var remove = Context.Books.Find(1);
                Context.Remove(remove);
                Context.SaveChanges();

                if (true)
                {
                    Console.WriteLine("Delete True");
                }
            }
            else if (info == "4")
            {
               var update= Context.Books.Update(Context.Books.First());
                Context.SaveChanges(true);
                if ( true)
                {
                    Console.WriteLine("Update True");
                }
            }

        }
    }
}
