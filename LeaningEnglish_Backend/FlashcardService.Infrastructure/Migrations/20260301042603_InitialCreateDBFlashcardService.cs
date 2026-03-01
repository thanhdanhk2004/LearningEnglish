using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashcardService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateDBFlashcardService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flashcards",
                columns: table => new
                {
                    FlashcardId = table.Column<Guid>(type: "uuid", nullable: false),
                    FlashcardName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    FlashcardDescription = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    FlashcardType = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flashcards", x => x.FlashcardId);
                });

            migrationBuilder.CreateTable(
                name: "Vocabularies",
                columns: table => new
                {
                    VobId = table.Column<Guid>(type: "uuid", nullable: false),
                    Terminology = table.Column<string>(type: "text", nullable: true),
                    Define = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    FlashcardId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vocabularies", x => x.VobId);
                    table.ForeignKey(
                        name: "FK_Vocabularies_Flashcards_FlashcardId",
                        column: x => x.FlashcardId,
                        principalTable: "Flashcards",
                        principalColumn: "FlashcardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vocabularies_FlashcardId",
                table: "Vocabularies",
                column: "FlashcardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vocabularies");

            migrationBuilder.DropTable(
                name: "Flashcards");
        }
    }
}
