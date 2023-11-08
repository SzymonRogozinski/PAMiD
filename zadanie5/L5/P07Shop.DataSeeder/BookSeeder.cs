using Bogus;
using P06Shop.Shared.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Shop.DataSeeder
{
    public class BookSeeder
    {
        private static string[] GenreNames = { "Criminal","Comic","Drama","Romance","Horror","Action","History"};
        private static Random random = new Random();

        public static List<P06Shop.Shared.Library.Book> GenerateProductData()
        {
            int productId = 1;
            var productFaker = new Faker<P06Shop.Shared.Library.Book>()
                .UseSeed(692137)
                .RuleFor(x => x.name, f => f.Lorem.Word() + " " + f.Lorem.Word())
                .RuleFor(x => x.author, f => f.Name.FullName())
                .RuleFor(x => x.pages, f => f.Random.Int(50, 2000))
                .RuleFor(x => x.genres, f => GenerateGenres())
                .RuleFor(x => x.id, f => productId++);

            return productFaker.Generate(10).ToList();

        }

        private static List<Genre> GenerateGenres ()
        { 
            
            List<Genre> genres = new List<Genre>();
            int range=random.Next(1,4);
            for (int i = 0; i < range; i++) 
            {
                genres.Add(new Genre(GenreNames[random.Next(GenreNames.Length)]));
            }
            return genres; 
        }
    }
}