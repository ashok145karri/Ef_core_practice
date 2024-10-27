using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addBookDetailUsingFLuentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_BookDetails",
                columns: table => new
                {
                    BookDetailId = table.Column<int>(name: "BookDetail_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoOfChapters = table.Column<int>(type: "int", nullable: false),
                    NumberOfPages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_BookDetails", x => x.BookDetailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_BookDetails");
        }
    }
}
