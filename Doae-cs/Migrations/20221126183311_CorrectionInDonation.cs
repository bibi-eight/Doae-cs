using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doae_cs.Migrations
{
    public partial class CorrectionInDonation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Suspend",
                table: "Donations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Suspend",
                table: "Donations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
