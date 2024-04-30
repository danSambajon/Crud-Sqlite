using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class ModAbnormalities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParticularsC",
                table: "Abnormalities");

            migrationBuilder.DropColumn(
                name: "ParticularsO",
                table: "Abnormalities");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Abnormalities",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Short",
                table: "Abnormalities",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Abnormalities");

            migrationBuilder.DropColumn(
                name: "Short",
                table: "Abnormalities");

            migrationBuilder.AddColumn<string>(
                name: "ParticularsC",
                table: "Abnormalities",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParticularsO",
                table: "Abnormalities",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
