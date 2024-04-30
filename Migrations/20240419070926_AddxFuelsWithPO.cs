using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class AddxFuelsWithPO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FuelsWithPOs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Start = table.Column<TimeOnly>(type: "TEXT", nullable: true),
                    End = table.Column<TimeOnly>(type: "TEXT", nullable: true),
                    INV_DATE = table.Column<string>(type: "TEXT", nullable: false),
                    XCorpcode = table.Column<int>(type: "INTEGER", nullable: false),
                    XSitecode = table.Column<int>(type: "INTEGER", nullable: false),
                    XTank = table.Column<int>(type: "INTEGER", nullable: false),
                    XPump = table.Column<int>(type: "INTEGER", nullable: false),
                    XNozzle = table.Column<int>(type: "INTEGER", nullable: false),
                    XYear = table.Column<int>(type: "INTEGER", nullable: false),
                    XMonth = table.Column<int>(type: "INTEGER", nullable: false),
                    XDay = table.Column<int>(type: "INTEGER", nullable: false),
                    XTransaction = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    XAmountDb = table.Column<double>(type: "REAL", nullable: false),
                    XAmount = table.Column<double>(type: "REAL", nullable: false),
                    Calibration = table.Column<double>(type: "REAL", nullable: false),
                    Volume = table.Column<double>(type: "REAL", nullable: false),
                    XItemcode = table.Column<string>(type: "TEXT", nullable: false),
                    Particulars = table.Column<string>(type: "TEXT", nullable: false),
                    Opening = table.Column<double>(type: "REAL", nullable: false),
                    Closing = table.Column<double>(type: "REAL", nullable: false),
                    nozdown = table.Column<string>(type: "TEXT", nullable: false),
                    preInTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    InTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    preOutTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    OutTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Liters = table.Column<double>(type: "REAL", nullable: false),
                    XOid = table.Column<string>(type: "TEXT", nullable: false),
                    XOname = table.Column<string>(type: "TEXT", nullable: false),
                    Shift = table.Column<int>(type: "INTEGER", nullable: false),
                    plateno = table.Column<string>(type: "TEXT", nullable: false),
                    pono = table.Column<string>(type: "TEXT", nullable: false),
                    Cust = table.Column<double>(type: "REAL", nullable: false),
                    Transcount = table.Column<int>(type: "INTEGER", nullable: false),
                    IsOffline = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelsWithPOs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuelsWithPOs");
        }
    }
}
