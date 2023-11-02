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
             .IsRequired()
             .HasConversion(
                v => ConvertGenreListToString(v),
                v => ConvertStringToGenreList(v)
                );

            modelBuilder.Entity<Book>().HasKey(p => p.id);

            // data seed 

            modelBuilder.Entity<Book>().HasData(BookSeeder.GenerateProductData());
        }

        private string ConvertGenreListToString(List<Genre> genres) 
        {
            string result="";
            for (int i = 0; i < genres.Count-1; i++)
            {
                result += genres[i].ToString() + ",";
            }
            result += genres[genres.Count - 1].ToString();
            return result;
        }

        private List<Genre> ConvertStringToGenreList(string genres)
        {
            List<Genre> result =new List<Genre>();
            string[] genreList= genres.Split(',');
            foreach (string g in genreList) 
            {
                result.Add(new Genre(g));
            }
            return result;
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