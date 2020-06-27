using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaPlace.Migrations
{
    public partial class OrderTableDateProcessed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateProcessed",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateProcessed",
                table: "Orders");
        }
    }
}
