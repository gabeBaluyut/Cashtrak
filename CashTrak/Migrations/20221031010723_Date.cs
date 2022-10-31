using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashTrak.Migrations
{
    public partial class Date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "CashRequests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "CashRequests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CashRequests",
                keyColumn: "CashRequestID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CashRequests",
                keyColumn: "CashRequestID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CashRequests",
                keyColumn: "CashRequestID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CashRequests",
                keyColumn: "CashRequestID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "CashRequests");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "CashRequests");
        }
    }
}
