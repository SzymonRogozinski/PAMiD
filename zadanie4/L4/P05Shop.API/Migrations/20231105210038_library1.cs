using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class library1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 1,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 2,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 3,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 4,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 5,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 6,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 7,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 8,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 10,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 1,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 2,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 3,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 4,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 5,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 6,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 7,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 8,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 10,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre");
        }
    }
}
