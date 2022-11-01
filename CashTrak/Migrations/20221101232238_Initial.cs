using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashTrak.Migrations
{
    public partial class Initial : Migration
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
                    CreationDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRequests", x => x.CashRequestID);
                });

            migrationBuilder.InsertData(
                table: "CashRequests",
                columns: new[] { "CashRequestID", "Amount", "CreationDate", "Description", "DueDate", "Recipent", "State", "Type", "User" },
                values: new object[,]
                {
                    { 1, 15.99, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owe me money for food man", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", "Created", "Incoming", "Justin" },
                    { 2, 35.0, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lost a bet", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel", "Created", "Incoming", "Justin" },
                    { 3, 15.99, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owe me money for food man", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", "Created", "Outgoing", "Justin" },
                    { 4, 22.25, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantasy NBA payment", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel", "Created", "Outgoing", "Justin" },
                    { 5, 15.99, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owe me money for food man", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dave", "Complete", "Incoming", "Justin" },
                    { 6, 35.0, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lost a bet", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donna", "Complete", "Incoming", "Justin" },
                    { 7, 55.549999999999997, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sold a pair of tic tacs for 55bucks", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "Complete", "Outgoing", "Justin" },
                    { 8, 16.949999999999999, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Food money", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miko", "Complete", "Outgoing", "Justin" },
                    { 9, 5.9500000000000002, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Payment for homework", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eric", "Complete", "Outgoing", "Justin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashRequests");
        }
    }
}
