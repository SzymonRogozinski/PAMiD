using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class new_migration : Migration
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

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "genres", "name", "pages" },
                values: new object[,]
                {
                    { 1, "Dagmar Hackett", "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre", "et cumque", 423 },
                    { 2, "Orval Tillman", "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre", "error cupiditate", 1127 },
                    { 3, "Tyson Hudson", "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre", "placeat qui", 848 },
                    { 4, "Janessa Botsford", "P06Shop.Shared.Library.Genre", "ab non", 323 },
                    { 5, "Lera Flatley", "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre", "et blanditiis", 206 },
                    { 6, "Earnestine Sauer", "P06Shop.Shared.Library.Genre", "quis beatae", 541 },
                    { 7, "Chad Grimes", "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre", "omnis veritatis", 221 },
                    { 8, "Tina Cassin", "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre", "est ut", 980 },
                    { 9, "Aidan Gleason", "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre", "ad officiis", 898 },
                    { 10, "Griffin Mayert", "P06Shop.Shared.Library.Genre", "minima aut", 1090 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
