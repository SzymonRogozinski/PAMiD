using Microsoft.EntityFrameworkCore;
using P06Shop.Shared.Library;
using P07Shop.DataSeeder;

namespace P05Shop.API.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api 
            modelBuilder.Entity<Book>()
                .Property(p => p.name)
                .IsRequired()
                .HasMaxLength(80);

            modelBuilder.Entity<Book>()
                .Property(p => p.author)
                .IsRequired()
                .HasMaxLength(60);

            modelBuilder.Entity<Book>()
             .Property(p => p.pages)
             .IsRequired();

            modelBuilder.Entity<Book>()
             .Property(p => p.id)
             .IsRequired();

            modelBuilder.Entity<Book>()
             .Property(p => p.genres)
             .IsRequired();

            modelBuilder.Entity<Book>().HasKey(p => p.id);

            // data seed 

            modelBuilder.Entity<Book>().HasData(BookSeeder.GenerateProductData());
        }
    }
}
// instalacja dotnet ef 
//dotnet tool install --global dotnet-ef

// aktualizacja 
//dotnet tool update --global dotnet-ef

// dotnet ef migrations add [nazwa_migracji]
// dotnet ef database update 

// cofniecie migraji niezaplikowanych 
//dotnet ef migrations remove