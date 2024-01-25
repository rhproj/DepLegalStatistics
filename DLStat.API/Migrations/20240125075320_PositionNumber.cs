using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DLStat.API.Migrations
{
    /// <inheritdoc />
    public partial class PositionNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionNumber",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionNumber",
                table: "Positions");
        }
    }
}
