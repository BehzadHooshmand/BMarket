using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BMarket.Persistence.Migrations
{
    public partial class Add_Viewcount_To_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 4, 2, 0, 36, 17, 424, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 4, 2, 0, 36, 17, 436, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 4, 2, 0, 36, 17, 436, DateTimeKind.Local).AddTicks(8534));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 3, 30, 1, 50, 11, 352, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 3, 30, 1, 50, 11, 385, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 3, 30, 1, 50, 11, 385, DateTimeKind.Local).AddTicks(5782));
        }
    }
}
