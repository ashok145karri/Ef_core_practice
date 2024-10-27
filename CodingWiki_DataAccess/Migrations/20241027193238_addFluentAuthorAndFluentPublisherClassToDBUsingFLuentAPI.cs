using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addFluentAuthorAndFluentPublisherClassToDBUsingFLuentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fluent_PublisherPublisher_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fluent_Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(name: "Author_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                { 
                    table.PrimaryKey("PK_Fluent_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(name: "Publisher_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_Publishers", x => x.PublisherId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropTable(
                name: "Fluent_Authors");

            migrationBuilder.DropTable(
                name: "Fluent_Publishers");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Fluent_PublisherPublisher_Id",
                table: "Fluent_Books");
        }
    }
}
