using DoAn2VADT.Database.Entities;
using Microsoft.EntityFrameworkCore;
using DoAn2VADT.ViewModels.Book;

namespace DoAn2VADT.Database
{
    public class AppDbContext: DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
        }
        public DbSet<DoAn2VADT.ViewModels.Book.ListItemBook> ListItemBook { get; set; }
    }
}
