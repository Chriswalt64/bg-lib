using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bg_lib.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsPlayToWin = table.Column<int>(type: "INTEGER", nullable: false),
                    IsInCirculation = table.Column<int>(type: "INTEGER", nullable: false),
                    IsCheckedOut = table.Column<int>(type: "INTEGER", nullable: false),
                    LastCheckoutDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastCheckinDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
