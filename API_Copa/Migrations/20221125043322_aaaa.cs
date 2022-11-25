using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class aaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "golsSelecaoA",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "golsSelecaoB",
                table: "Jogos");

            migrationBuilder.CreateTable(
                name: "Palpites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    golsSelecaoA = table.Column<int>(type: "INTEGER", nullable: false),
                    golsSelecaoB = table.Column<int>(type: "INTEGER", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palpites", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Palpites");

            migrationBuilder.AddColumn<int>(
                name: "golsSelecaoA",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "golsSelecaoB",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
