using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addFluentonetomanyRelationbookandpublisherrevertingsmallfixwhichaddedbecauseuncommentingtheline35influentbooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Books_Fluent_BookBookId",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookAuthorMap_Fluent_BookBookId",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropColumn(
                name: "Fluent_BookBookId",
                table: "Fluent_BookAuthorMap");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fluent_BookBookId",
                table: "Fluent_BookAuthorMap",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookAuthorMap_Fluent_BookBookId",
                table: "Fluent_BookAuthorMap",
                column: "Fluent_BookBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Books_Fluent_BookBookId",
                table: "Fluent_BookAuthorMap",
                column: "Fluent_BookBookId",
                principalTable: "Fluent_Books",
                principalColumn: "BookId");
        }
    }
}
