using Book_Data;

namespace Book_AppMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var Context = new BookDbContext())
            {
                Context.Database.EnsureCreated();
            }
            AddUser add = new AddUser();
            add.adduser();
            add.viewuser();
            AddBooks add1=new AddBooks();
            add1.addbook();
            add1.getbook();

        }
    }
}