using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doae_cs.Migrations
{
    public partial class RemoveSuspend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Suspend",
                table: "Targets");

            migrationBuilder.DropColumn(
                name: "Suspend",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "Suspend",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "Suspend",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Institutions");

            migrationBuilder.AlterColumn<string>(
                name: "Count",
                table: "Institutions",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Suspend",
                table: "Targets",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Suspend",
                table: "Publications",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Suspend",
                table: "Products",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Count",
                table: "Institutions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Institutions",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Institutions",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Institutions",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "Suspend",
                table: "Institutions",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Institutions",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
