using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addFluentonetomanyRelationbookandpublisher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Fluent_PublisherPublisher_Id",
                table: "Fluent_Books");

            migrationBuilder.AddColumn<int>(
                name: "Publisher_id",
                table: "Fluent_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fluent_BookAuthorMap",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(name: "Author_Id", type: "int", nullable: false),
                    FluentBookBookId = table.Column<int>(name: "Fluent_BookBookId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_BookAuthorMap", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_Fluent_BookAuthorMap_Fluent_Books_Fluent_BookBookId",
                        column: x => x.FluentBookBookId,
                        principalTable: "Fluent_Books",
                        principalColumn: "BookId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_Publisher_id",
                table: "Fluent_Books",
                column: "Publisher_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookAuthorMap_Fluent_BookBookId",
                table: "Fluent_BookAuthorMap",
                column: "Fluent_BookBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Publisher_id",
                table: "Fluent_Books",
                column: "Publisher_id",
                principalTable: "Fluent_Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Publisher_id",
                table: "Fluent_Books");

            migrationBuilder.DropTable(
                name: "Fluent_BookAuthorMap");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Publisher_id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Publisher_id",
                table: "Fluent_Books");

            migrationBuilder.AddColumn<int>(
                name: "Fluent_PublisherPublisher_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books",
                column: "Fluent_PublisherPublisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books",
                column: "Fluent_PublisherPublisher_Id",
                principalTable: "Fluent_Publishers",
                principalColumn: "Publisher_Id");
        }
    }
}
