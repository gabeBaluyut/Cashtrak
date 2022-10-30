using Microsoft.EntityFrameworkCore.Migrations;

namespace CashTrak.Migrations
{
    public partial class Initialize : Migration
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
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRequests", x => x.CashRequestID);
                });

            migrationBuilder.InsertData(
                table: "CashRequests",
                columns: new[] { "CashRequestID", "Amount", "Description", "Recipent", "Type", "User" },
                values: new object[,]
                {
                    { 1, 15.99, "Owe me money for food man", "Jason", "Incoming", "Justin" },
                    { 2, 35.0, "Lost a bet", "Gabriel", "Incoming", "Justin" },
                    { 3, 15.99, "Owe me money for food man", "Jason", "Outgoing", "Justin" },
                    { 4, 22.25, "Fantasy NBA payment", "Gabriel", "Outgoing", "Justin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashRequests");
        }
    }
}
