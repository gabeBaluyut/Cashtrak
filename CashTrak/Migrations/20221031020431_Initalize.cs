using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashTrak.Migrations
{
    public partial class Initalize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashRequests",
                columns: table => new
                {
                    CashRequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(nullable: true),
                    Recipent = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRequests", x => x.CashRequestID);
                });

            migrationBuilder.InsertData(
                table: "CashRequests",
                columns: new[] { "CashRequestID", "Amount", "CreationDate", "Description", "DueDate", "Recipent", "Type", "User" },
                values: new object[,]
                {
                    { 1, 15.99, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owe me money for food man", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", "Incoming", "Justin" },
                    { 2, 35.0, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lost a bet", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel", "Incoming", "Justin" },
                    { 3, 15.99, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owe me money for food man", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", "Outgoing", "Justin" },
                    { 4, 22.25, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantasy NBA payment", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel", "Outgoing", "Justin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashRequests");
        }
    }
}
