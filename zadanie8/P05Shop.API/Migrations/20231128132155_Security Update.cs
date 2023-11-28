using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class SecurityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 1,
                column: "genres",
                value: "Drama,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 2,
                column: "genres",
                value: "Criminal");

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
                value: "Criminal,Action,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 5,
                column: "genres",
                value: "Romance,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 6,
                column: "genres",
                value: "Horror,History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 7,
                column: "genres",
                value: "Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 8,
                column: "genres",
                value: "Romance,Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 10,
                column: "genres",
                value: "Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 11,
                column: "genres",
                value: "Criminal,Comic,History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 12,
                column: "genres",
                value: "Criminal,Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 13,
                column: "genres",
                value: "Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 14,
                column: "genres",
                value: "Horror,Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 15,
                column: "genres",
                value: "Drama,Horror,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 16,
                column: "genres",
                value: "Drama,Action,Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 17,
                column: "genres",
                value: "History,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 18,
                column: "genres",
                value: "Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 19,
                column: "genres",
                value: "Romance,Comic,History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 20,
                column: "genres",
                value: "Romance,Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 21,
                column: "genres",
                value: "Romance,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 22,
                column: "genres",
                value: "Action,Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 23,
                column: "genres",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 24,
                column: "genres",
                value: "Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 25,
                column: "genres",
                value: "History,Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 26,
                column: "genres",
                value: "Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 27,
                column: "genres",
                value: "Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 28,
                column: "genres",
                value: "Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 29,
                column: "genres",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 30,
                column: "genres",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 31,
                column: "genres",
                value: "Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 32,
                column: "genres",
                value: "Drama,History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 33,
                column: "genres",
                value: "Comic,Romance,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 34,
                column: "genres",
                value: "Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 35,
                column: "genres",
                value: "Romance,Comic,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 36,
                column: "genres",
                value: "Drama");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 37,
                column: "genres",
                value: "Drama,Comic,History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 38,
                column: "genres",
                value: "History,Criminal,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 39,
                column: "genres",
                value: "Horror,Comic,Drama");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 40,
                column: "genres",
                value: "Action,Romance");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
                keyValue: 10,
                column: "genres",
                value: "Drama,History,Drama");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 11,
                column: "genres",
                value: "Drama,Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 12,
                column: "genres",
                value: "Romance,Criminal,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 13,
                column: "genres",
                value: "Criminal,Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 14,
                column: "genres",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 15,
                column: "genres",
                value: "Criminal,Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 16,
                column: "genres",
                value: "Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 17,
                column: "genres",
                value: "Romance,Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 18,
                column: "genres",
                value: "Romance,Action,Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 19,
                column: "genres",
                value: "Comic,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 20,
                column: "genres",
                value: "Horror,Criminal,Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 21,
                column: "genres",
                value: "Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 22,
                column: "genres",
                value: "Drama");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 23,
                column: "genres",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 24,
                column: "genres",
                value: "Horror,History,Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 25,
                column: "genres",
                value: "Romance,Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 26,
                column: "genres",
                value: "Horror,Romance,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 27,
                column: "genres",
                value: "Drama,Horror,Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 28,
                column: "genres",
                value: "Romance,Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 29,
                column: "genres",
                value: "Drama,Horror,Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 30,
                column: "genres",
                value: "Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 31,
                column: "genres",
                value: "Horror");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 32,
                column: "genres",
                value: "Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 33,
                column: "genres",
                value: "Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 34,
                column: "genres",
                value: "Comic,Criminal,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 35,
                column: "genres",
                value: "Comic,Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 36,
                column: "genres",
                value: "Criminal,Romance,Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 37,
                column: "genres",
                value: "Action,Horror,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 38,
                column: "genres",
                value: "Romance,Comic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 39,
                column: "genres",
                value: "Action,Drama");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 40,
                column: "genres",
                value: "Horror,Comic,Comic");
        }
    }
}
