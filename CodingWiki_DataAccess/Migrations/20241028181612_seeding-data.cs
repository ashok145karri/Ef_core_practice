using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fluent_Publishers",
                columns: new[] { "Publisher_Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "chicago", "onetomany" },
                    { 2, "france", "onetomanysample" },
                    { 3, "china", "onetomanyexample" }
                });

            migrationBuilder.InsertData(
                table: "Fluent_Books",
                columns: new[] { "BookId", "ISBN", "Price", "Publisher_id", "Title" },
                values: new object[,]
                {
                    { 1, "123ashok45", 19.0m, 1, "SpiderMan" },
                    { 2, "45kohsa", 55.99m, 1, "SuperMan" },
                    { 3, "8546lk", 66.88m, 2, "Batman" },
                    { 4, "82grs6", 2.99m, 3, "Flash" },
                    { 5, "1234", 2.09m, 3, "captain" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fluent_Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fluent_Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fluent_Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fluent_Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fluent_Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fluent_Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fluent_Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fluent_Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 3);
        }
    }
}
