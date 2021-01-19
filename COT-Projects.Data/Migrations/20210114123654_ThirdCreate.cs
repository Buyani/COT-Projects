using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COT_Projects.Data.Migrations
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChangeLong",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChangeShort",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Reports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LongPercent",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Netpositions",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShortPercent",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangeLong",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ChangeShort",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "LongPercent",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Netpositions",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ShortPercent",
                table: "Reports");
        }
    }
}
