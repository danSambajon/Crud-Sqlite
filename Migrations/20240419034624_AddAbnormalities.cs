using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class AddAbnormalities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abnormalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OpeningZip = table.Column<double>(type: "REAL", nullable: false),
                    ClosingZip = table.Column<double>(type: "REAL", nullable: false),
                    Abnormality = table.Column<double>(type: "REAL", nullable: false),
                    ParticularsO = table.Column<string>(type: "TEXT", nullable: false),
                    ParticularsC = table.Column<string>(type: "TEXT", nullable: false),
                    INV_DATE = table.Column<string>(type: "TEXT", nullable: false),
                    XPump = table.Column<int>(type: "INTEGER", nullable: false),
                    Opening = table.Column<double>(type: "REAL", nullable: false),
                    Closing = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abnormalities", x => x.Id);
                });
        }
    }
}
