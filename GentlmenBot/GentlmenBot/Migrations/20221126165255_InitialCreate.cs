using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentlmenBot.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    LineManager = table.Column<string>(type: "TEXT", nullable: true),
                    LocalPeoplePartner = table.Column<string>(type: "TEXT", nullable: true),
                    NextPerfomanceReview = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    EnglishCources = table.Column<string>(type: "TEXT", nullable: true),
                    EnglishCourcesCostCoverage = table.Column<int>(type: "INTEGER", nullable: false),
                    PossibleMentor = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
