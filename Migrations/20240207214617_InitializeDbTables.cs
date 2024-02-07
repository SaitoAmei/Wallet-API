using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wallet_API.Migrations
{
    /// <inheritdoc />
    public partial class InitializeDbTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    TransactionType = table.Column<string>(type: "text", nullable: false),
                    TransactionAmount = table.Column<int>(type: "integer", nullable: false),
                    TransactionName = table.Column<string>(type: "text", nullable: false),
                    TransactionDescription = table.Column<string>(type: "text", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TransactionStatus = table.Column<string>(type: "text", nullable: false),
                    TransactionIcon = table.Column<string>(type: "text", nullable: false),
                    TransactionSenderId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transactions_Users_TransactionSenderId",
                        column: x => x.TransactionSenderId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "ID", "TransactionAmount", "TransactionDate", "TransactionDescription", "TransactionIcon", "TransactionName", "TransactionSenderId", "TransactionStatus", "TransactionType", "UserId" },
                values: new object[,]
                {
                    { 3, 324, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8783), "Description for Transaction 3", "dark-bg3 icon1", "Transaction 3 for Common User", null, "Completed", "Payment", 1 },
                    { 4, 212, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8835), "Description for Transaction 4", "dark-bg2 icon1", "Transaction 4 for Common User", null, "Completed", "Payment", 1 },
                    { 6, 312, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8855), "Description for Transaction 6", "dark-bg1 icon2", "Transaction 6 for Common User", null, "Completed", "Credit", 1 },
                    { 7, 239, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8864), "Description for Transaction 7", "dark-bg2 icon2", "Transaction 7 for Common User", null, "Completed", "Credit", 1 },
                    { 9, 812, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8878), "Description for Transaction 9", "dark-bg3 icon3", "Transaction 9 for Common User", null, "Pending", "Credit", 1 },
                    { 10, 502, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8883), "Description for Transaction 10", "dark-bg3 icon1", "Transaction 10 for Common User", null, "Pending", "Credit", 1 },
                    { 12, 436, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8896), "Description for Transaction 12", "dark-bg2 icon1", "Transaction 12 for Common User", null, "Completed", "Credit", 1 },
                    { 13, 944, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8903), "Description for Transaction 13", "dark-bg1 icon1", "Transaction 13 for Common User", null, "Completed", "Credit", 1 },
                    { 15, 789, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8913), "Description for Transaction 15", "dark-bg1 icon3", "Transaction 15 for Common User", null, "Completed", "Credit", 1 },
                    { 16, 690, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8918), "Description for Transaction 16", "dark-bg1 icon1", "Transaction 16 for Common User", null, "Completed", "Payment", 1 },
                    { 18, 270, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8930), "Description for Transaction 18", "dark-bg2 icon1", "Transaction 18 for Common User", null, "Completed", "Payment", 1 },
                    { 19, 478, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8936), "Description for Transaction 19", "dark-bg1 icon1", "Transaction 19 for Common User", null, "Pending", "Payment", 1 },
                    { 21, 370, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8947), "Description for Transaction 21", "dark-bg3 icon2", "Transaction 21 for Common User", null, "Pending", "Credit", 1 },
                    { 22, 509, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8952), "Description for Transaction 22", "dark-bg1 icon3", "Transaction 22 for Common User", null, "Pending", "Credit", 1 },
                    { 24, 530, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8998), "Description for Transaction 24", "dark-bg1 icon2", "Transaction 24 for Common User", null, "Pending", "Credit", 1 },
                    { 25, 216, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9005), "Description for Transaction 25", "dark-bg1 icon3", "Transaction 25 for Common User", null, "Pending", "Payment", 1 },
                    { 27, 474, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9015), "Description for Transaction 27", "dark-bg1 icon1", "Transaction 27 for Common User", null, "Pending", "Payment", 1 },
                    { 28, 815, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9019), "Description for Transaction 28", "dark-bg3 icon3", "Transaction 28 for Common User", null, "Pending", "Credit", 1 },
                    { 30, 772, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9030), "Description for Transaction 30", "dark-bg3 icon2", "Transaction 30 for Common User", null, "Completed", "Payment", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Common User" },
                    { 2, true, "Jane Doe" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "ID", "TransactionAmount", "TransactionDate", "TransactionDescription", "TransactionIcon", "TransactionName", "TransactionSenderId", "TransactionStatus", "TransactionType", "UserId" },
                values: new object[,]
                {
                    { 2, 872, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8767), "Description for Transaction 2", "dark-bg3 icon1", "Transaction 2 for Common User", 2, "Pending", "Credit", 1 },
                    { 5, 472, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8850), "Description for Transaction 5", "dark-bg2 icon1", "Transaction 5 for Common User", 2, "Completed", "Credit", 1 },
                    { 8, 492, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8869), "Description for Transaction 8", "dark-bg1 icon1", "Transaction 8 for Common User", 2, "Completed", "Credit", 1 },
                    { 11, 332, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8890), "Description for Transaction 11", "dark-bg3 icon3", "Transaction 11 for Common User", 2, "Completed", "Payment", 1 },
                    { 14, 732, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8908), "Description for Transaction 14", "dark-bg3 icon3", "Transaction 14 for Common User", 2, "Pending", "Credit", 1 },
                    { 17, 808, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8925), "Description for Transaction 17", "dark-bg1 icon2", "Transaction 17 for Common User", 2, "Completed", "Credit", 1 },
                    { 20, 917, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8941), "Description for Transaction 20", "dark-bg1 icon2", "Transaction 20 for Common User", 2, "Completed", "Credit", 1 },
                    { 23, 193, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8993), "Description for Transaction 23", "dark-bg3 icon3", "Transaction 23 for Common User", 2, "Completed", "Credit", 1 },
                    { 26, 642, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9010), "Description for Transaction 26", "dark-bg3 icon1", "Transaction 26 for Common User", 2, "Pending", "Credit", 1 },
                    { 29, 359, new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9025), "Description for Transaction 29", "dark-bg1 icon1", "Transaction 29 for Common User", 2, "Completed", "Credit", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransactionSenderId",
                table: "Transactions",
                column: "TransactionSenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
