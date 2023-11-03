using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doae_cs.Migrations
{
    public partial class CorrectionInTarget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "Targets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TargetId",
                table: "Targets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
