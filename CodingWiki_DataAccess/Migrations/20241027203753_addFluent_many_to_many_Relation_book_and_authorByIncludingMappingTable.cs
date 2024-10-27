using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addFluentmanytomanyRelationbookandauthorByIncludingMappingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookAuthorMap_BookId",
                table: "Fluent_BookAuthorMap",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthorMap",
                column: "Author_Id",
                principalTable: "Fluent_Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Books_BookId",
                table: "Fluent_BookAuthorMap",
                column: "BookId",
                principalTable: "Fluent_Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Books_BookId",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookAuthorMap_BookId",
                table: "Fluent_BookAuthorMap");
        }
    }
}
