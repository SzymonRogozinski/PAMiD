using Bogus;
using P06Shop.Shared.Library;
using P06Shop.Shared.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Shop.DataSeeder
{
    public class BookSeeder
    {

        public static List<Book> GenerateProductData()
        {
            int productId = 1;
            var productFaker = new Faker<Book>()
                .RuleFor(x => x.name, f => f.Lorem.Word() + " " + f.Lorem.Word())
                .RuleFor(x => x.author, f => f.Name.FullName())
                .RuleFor(x => x.pages, f => f.Random.Int(50, 2000))
                .RuleFor(x => x.genres, f => GenerateGenres());

            return productFaker.Generate(10).ToList();

        }

        private static List<Genre> GenerateGenres ()
        { 
            return null; 
        }
    }
}