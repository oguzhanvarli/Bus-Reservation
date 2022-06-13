using Microsoft.EntityFrameworkCore.Migrations;

namespace BusReservation.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RouteStart = table.Column<string>(type: "TEXT", nullable: true),
                    RouteFirstTransfer = table.Column<string>(type: "TEXT", nullable: true),
                    RouteSecondTransfer = table.Column<string>(type: "TEXT", nullable: true),
                    RouteThirdTransfer = table.Column<string>(type: "TEXT", nullable: true),
                    RouteFourthTransfer = table.Column<string>(type: "TEXT", nullable: true),
                    RouteFinish = table.Column<string>(type: "TEXT", nullable: true),
                    RouteDate = table.Column<string>(type: "TEXT", nullable: true),
                    RouteClock = table.Column<string>(type: "TEXT", nullable: true),
                    RoutePrice = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityName = table.Column<string>(type: "TEXT", nullable: true),
                    RouteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TicketName = table.Column<string>(type: "TEXT", nullable: true),
                    TicketSurname = table.Column<string>(type: "TEXT", nullable: true),
                    TicketGender = table.Column<string>(type: "TEXT", nullable: true),
                    TicketMail = table.Column<string>(type: "TEXT", nullable: true),
                    TicketFromWhere = table.Column<string>(type: "TEXT", nullable: true),
                    TicketToWhere = table.Column<string>(type: "TEXT", nullable: true),
                    TicketDate = table.Column<string>(type: "TEXT", nullable: true),
                    TicketPrice = table.Column<double>(type: "REAL", nullable: false),
                    TicketSeatNo = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketClock = table.Column<string>(type: "TEXT", nullable: true),
                    TicketPnrNo = table.Column<int>(type: "INTEGER", nullable: false),
                    RouteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_RouteId",
                table: "Cities",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RouteId",
                table: "Tickets",
                column: "RouteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
