using Book_Domain;
using Microsoft.EntityFrameworkCore;

namespace Book_Data
{
    public class BookDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial catalog =UserBooks");
        }
    }
}