using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DLStat.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Operatives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperativeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operatives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResponseMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    OperativeId = table.Column<int>(type: "int", nullable: false),
                    FillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportingWeek = table.Column<byte>(type: "tinyint", nullable: false),
                    ReportingMonth = table.Column<byte>(type: "tinyint", nullable: false),
                    ReportingYear = table.Column<int>(type: "int", nullable: false),
                    BySK = table.Column<int>(type: "int", nullable: false),
                    ByMVD = table.Column<int>(type: "int", nullable: false),
                    ByFSB = table.Column<int>(type: "int", nullable: false),
                    Overall = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseMeasures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponseMeasures_Operatives_OperativeId",
                        column: x => x.OperativeId,
                        principalTable: "Operatives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponseMeasures_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResponseMeasures_OperativeId",
                table: "ResponseMeasures",
                column: "OperativeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseMeasures_PositionId",
                table: "ResponseMeasures",
                column: "PositionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponseMeasures");

            migrationBuilder.DropTable(
                name: "Operatives");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
