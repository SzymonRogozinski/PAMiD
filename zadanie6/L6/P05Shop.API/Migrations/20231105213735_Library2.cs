﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class Library2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 1,
                column: "genres",
                value: "Criminal");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 2,
                column: "genres",
                value: "Action,Horror,Action");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 3,
                column: "genres",
                value: "History,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 4,
                column: "genres",
                value: "Drama,Criminal,History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 5,
                column: "genres",
                value: "Horror,Romance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 6,
                column: "genres",
                value: "Drama");

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
                value: "History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 9,
                column: "genres",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 10,
                column: "genres",
                value: "Romance,Horror,Horror");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 9,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "id",
                keyValue: 10,
                column: "genres",
                value: "P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre,P06Shop.Shared.Library.Genre");
        }
    }
}
