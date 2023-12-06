using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class Initialinewdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    author = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    pages = table.Column<int>(type: "int", nullable: false),
                    genres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "genres", "name", "pages" },
                values: new object[,]
                {
                    { 1, "Dagmar Hackett", "Romance,Criminal,Romance", "et cumque", 423 },
                    { 2, "Orval Tillman", "Horror,Romance,Action", "error cupiditate", 1127 },
                    { 3, "Tyson Hudson", "Comic,Drama,Criminal", "placeat qui", 848 },
                    { 4, "Janessa Botsford", "History,History,Horror", "ab non", 323 },
                    { 5, "Lera Flatley", "Drama,History,Romance", "et blanditiis", 206 },
                    { 6, "Earnestine Sauer", "Comic,Romance", "quis beatae", 541 },
                    { 7, "Chad Grimes", "Horror,Comic,History", "omnis veritatis", 221 },
                    { 8, "Tina Cassin", "Criminal", "est ut", 980 },
                    { 9, "Aidan Gleason", "Drama,Comic", "ad officiis", 898 },
                    { 10, "Griffin Mayert", "Horror,Romance,History", "minima aut", 1090 },
                    { 11, "Golda Jones", "Horror,Criminal", "ducimus dolor", 1129 },
                    { 12, "Wilber Farrell", "Criminal,Drama", "neque dicta", 1817 },
                    { 13, "Zoie Murray", "Romance", "corrupti et", 1592 },
                    { 14, "Maci Gutmann", "Comic,Horror,Criminal", "est est", 1613 },
                    { 15, "Evert Morissette", "Comic", "illum repellat", 1740 },
                    { 16, "Fannie Schoen", "Drama", "natus iusto", 1614 },
                    { 17, "Mckenzie Friesen", "Criminal,Action", "quia tempore", 1618 },
                    { 18, "Neva Robel", "Criminal,Horror,Horror", "qui nam", 1855 },
                    { 19, "May Erdman", "Horror,Action,Romance", "occaecati aliquam", 1978 },
                    { 20, "Gia Krajcik", "History", "doloremque officiis", 1506 },
                    { 21, "Bailee Sanford", "History", "et praesentium", 1449 },
                    { 22, "Orpha Luettgen", "Comic,Criminal", "ducimus fugiat", 1989 },
                    { 23, "Cecilia Kautzer", "Criminal,Drama", "est quod", 1476 },
                    { 24, "Neoma Shields", "Action,Romance,Action", "vel sed", 455 },
                    { 25, "Tad Hodkiewicz", "Comic,Criminal", "voluptatem eveniet", 596 },
                    { 26, "Bradley Murazik", "History", "natus ullam", 1679 },
                    { 27, "Savannah Beier", "Romance,Criminal", "nobis quae", 385 },
                    { 28, "Tina Lehner", "History,Romance,Comic", "porro in", 742 },
                    { 29, "Cleve Rogahn", "Criminal,Romance", "placeat rerum", 438 },
                    { 30, "Doug Kuhn", "Romance", "dolor dicta", 389 },
                    { 31, "Keenan Gleichner", "Romance,History,History", "quos quia", 1462 },
                    { 32, "Mireya Kunze", "Action", "minus unde", 359 },
                    { 33, "Camren Reichel", "Action", "voluptatem quo", 654 },
                    { 34, "Berniece Funk", "History,History", "cum et", 80 },
                    { 35, "Daisy Kozey", "History,Action", "labore est", 947 },
                    { 36, "Carroll Daugherty", "Comic,Criminal,Comic", "dolores cumque", 1020 },
                    { 37, "Lorna Kling", "Comic", "rem voluptatem", 717 },
                    { 38, "Lelah Hauck", "Action,History,History", "natus corrupti", 906 },
                    { 39, "Hollis Hilpert", "Romance,Comic,History", "dolorem at", 450 },
                    { 40, "Jarrett Kertzmann", "Drama,Action,Comic", "eaque id", 1065 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "Email", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 1, new DateTime(2023, 12, 6, 18, 38, 7, 662, DateTimeKind.Local).AddTicks(1774), "admin@admin.pl", new byte[] { 111, 81, 3, 109, 191, 7, 126, 212, 243, 175, 24, 120, 79, 221, 195, 112, 210, 193, 147, 40, 130, 49, 176, 189, 99, 105, 73, 40, 76, 192, 62, 41, 92, 36, 192, 147, 250, 249, 203, 165, 166, 124, 208, 189, 109, 138, 226, 25, 146, 31, 136, 237, 82, 62, 85, 49, 147, 28, 83, 216, 231, 154, 219, 68 }, new byte[] { 114, 202, 78, 100, 16, 28, 152, 133, 24, 58, 142, 114, 126, 103, 223, 168, 211, 71, 168, 45, 208, 239, 98, 137, 56, 36, 222, 71, 139, 37, 152, 31, 125, 191, 218, 166, 17, 214, 21, 18, 235, 183, 155, 40, 53, 91, 186, 26, 71, 160, 81, 53, 160, 21, 244, 221, 20, 233, 113, 235, 42, 234, 31, 37, 199, 238, 40, 168, 163, 22, 25, 202, 84, 112, 35, 1, 150, 48, 23, 166, 33, 57, 144, 24, 83, 134, 44, 5, 114, 15, 183, 121, 37, 101, 131, 2, 104, 107, 243, 36, 174, 11, 98, 230, 208, 198, 167, 31, 156, 144, 35, 221, 166, 63, 3, 232, 243, 13, 234, 169, 190, 69, 34, 75, 90, 127, 64, 75 }, "Admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
