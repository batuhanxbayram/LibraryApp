using LibraryApp.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Api.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options):base(options)
        {
            
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        



    }
}
