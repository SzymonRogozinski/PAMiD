using Microsoft.EntityFrameworkCore;
using P06Shop.Shared.Auth;
using P06Shop.Shared.Library;
using P07Shop.DataSeeder;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace P05Shop.API.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

        //public DbSet<User> Users { get; set; }

        public DbSet<User> Users { get; set; }

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

            //Users
            modelBuilder.Entity<User>()
                .ToTable("Users");

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(60);

            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(60);

            modelBuilder.Entity<User>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<User>().HasData(AddAdmin());
        }

        private string ConvertGenreListToString(List<Genre> genres) 
        {
            string result="";
            for (int i = 0; i < genres.Count-1; i++)
            {
                result += genres[i].name + ",";
            }
            result += genres[genres.Count - 1].name;
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

        private List<User> AddAdmin() 
        {
            var password = "admin";
            var res=new List<User>();
            var admin = new User() 
            { 
                Email = "admin@admin.pl",
                Username = "admin",
                Role = Roles.ADMIN,
                Id = 1
            };

            // create password hash and salt
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            // assign hash and salt to user
            admin.PasswordHash = passwordHash;
            admin.PasswordSalt = passwordSalt;

            res.Add(admin);
            return res;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            // using statement to dispose of IDisposable objects
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                // generate random salt
                passwordSalt = hmac.Key;
                // generate hash
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
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