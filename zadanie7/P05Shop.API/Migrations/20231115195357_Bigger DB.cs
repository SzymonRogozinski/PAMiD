using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class BiggerDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 1,
                column: "genres",
                value: "Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 2,
                column: "genres",
                value: "Romance,Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 3,
                column: "genres",
                value: "Comic,Romance,Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 4,
                column: "genres",
                value: "Comic,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 5,
                column: "genres",
                value: "Romance,Romance,Drama");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 6,
                column: "genres",
                value: "Criminal,Comic,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 7,
                column: "genres",
                value: "Horror,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 8,
                column: "genres",
                value: "Romance,Criminal,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 9,
                column: "genres",
                value: "Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 10,
                column: "genres",
                value: "Drama,History,Drama");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "genres", "name", "pages" },
                values: new object[,]
                {
                    { 11, "Golda Jones", "Drama,Comic", "ducimus dolor", 1129 },
                    { 12, "Wilber Farrell", "Romance,Criminal,Romance", "neque dicta", 1817 },
                    { 13, "Zoie Murray", "Criminal,Horror", "corrupti et", 1592 },
                    { 14, "Maci Gutmann", "History", "est est", 1613 },
                    { 15, "Evert Morissette", "Criminal,Horror", "illum repellat", 1740 },
                    { 16, "Fannie Schoen", "Comic", "natus iusto", 1614 },
                    { 17, "Mckenzie Friesen", "Romance,Comic", "quia tempore", 1618 },
                    { 18, "Neva Robel", "Romance,Action,Horror", "qui nam", 1855 },
                    { 19, "May Erdman", "Comic,Criminal", "occaecati aliquam", 1978 },
                    { 20, "Gia Krajcik", "Horror,Criminal,Action", "doloremque officiis", 1506 },
                    { 21, "Bailee Sanford", "Comic", "et praesentium", 1449 },
                    { 22, "Orpha Luettgen", "Drama", "ducimus fugiat", 1989 },
                    { 23, "Cecilia Kautzer", "History", "est quod", 1476 },
                    { 24, "Neoma Shields", "Horror,History,Criminal", "vel sed", 455 },
                    { 25, "Tad Hodkiewicz", "Romance,Action", "voluptatem eveniet", 596 },
                    { 26, "Bradley Murazik", "Horror,Romance,Romance", "natus ullam", 1679 },
                    { 27, "Savannah Beier", "Drama,Horror,Action", "nobis quae", 385 },
                    { 28, "Tina Lehner", "Romance,Comic", "porro in", 742 },
                    { 29, "Cleve Rogahn", "Drama,Horror,Action", "placeat rerum", 438 },
                    { 30, "Doug Kuhn", "Criminal", "dolor dicta", 389 },
                    { 31, "Keenan Gleichner", "Horror", "quos quia", 1462 },
                    { 32, "Mireya Kunze", "Romance", "minus unde", 359 },
                    { 33, "Camren Reichel", "Romance", "voluptatem quo", 654 },
                    { 34, "Berniece Funk", "Comic,Criminal,Romance", "cum et", 80 },
                    { 35, "Daisy Kozey", "Comic,Action", "labore est", 947 },
                    { 36, "Carroll Daugherty", "Criminal,Romance,Comic", "dolores cumque", 1020 },
                    { 37, "Lorna Kling", "Action,Horror,Romance", "rem voluptatem", 717 },
                    { 38, "Lelah Hauck", "Romance,Comic", "natus corrupti", 906 },
                    { 39, "Hollis Hilpert", "Action,Drama", "dolorem at", 450 },
                    { 40, "Jarrett Kertzmann", "Horror,Comic,Comic", "eaque id", 1065 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 1,
                column: "genres",
                value: "Romance,History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 2,
                column: "genres",
                value: "History,Horror,Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 3,
                column: "genres",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 4,
                column: "genres",
                value: "Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 5,
                column: "genres",
                value: "Criminal,Criminal,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 6,
                column: "genres",
                value: "Horror,Horror,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 7,
                column: "genres",
                value: "History,Horror,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 8,
                column: "genres",
                value: "Comic,Action,Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 9,
                column: "genres",
                value: "Action,Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 10,
                column: "genres",
                value: "Action,History,Horror");
        }
    }
}
