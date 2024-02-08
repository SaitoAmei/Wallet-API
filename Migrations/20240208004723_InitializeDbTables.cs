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
                name: "CardBalances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CardBalanceAmount = table.Column<float>(type: "real", nullable: false),
                    CardLimit = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardBalances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    { 3, 618, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1665), "Description for Transaction 3", "dark-bg3 icon1", "Transaction 3 for Common User", null, "Completed", "Payment", 1 },
                    { 4, 586, new DateTime(2024, 2, 7, 17, 27, 35, 0, DateTimeKind.Utc), "Description for Transaction 4", "dark-bg2 icon2", "Transaction 4 for Common User", null, "Completed", "Credit", 1 },
                    { 6, 158, new DateTime(2024, 2, 24, 9, 13, 59, 0, DateTimeKind.Utc), "Description for Transaction 6", "dark-bg1 icon1", "Transaction 6 for Common User", null, "Pending", "Credit", 1 },
                    { 7, 466, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1709), "Description for Transaction 7", "dark-bg3 icon1", "Transaction 7 for Common User", null, "Completed", "Credit", 1 },
                    { 9, 664, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1730), "Description for Transaction 9", "dark-bg1 icon3", "Transaction 9 for Common User", null, "Completed", "Credit", 1 },
                    { 10, 435, new DateTime(2024, 2, 26, 20, 19, 24, 0, DateTimeKind.Utc), "Description for Transaction 10", "dark-bg3 icon2", "Transaction 10 for Common User", null, "Pending", "Credit", 1 },
                    { 12, 172, new DateTime(2024, 2, 28, 4, 47, 4, 0, DateTimeKind.Utc), "Description for Transaction 12", "dark-bg3 icon3", "Transaction 12 for Common User", null, "Pending", "Payment", 1 },
                    { 13, 400, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1771), "Description for Transaction 13", "dark-bg1 icon1", "Transaction 13 for Common User", null, "Pending", "Payment", 1 },
                    { 15, 313, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1791), "Description for Transaction 15", "dark-bg1 icon2", "Transaction 15 for Common User", null, "Pending", "Credit", 1 },
                    { 16, 110, new DateTime(2024, 2, 1, 21, 38, 20, 0, DateTimeKind.Utc), "Description for Transaction 16", "dark-bg1 icon1", "Transaction 16 for Common User", null, "Completed", "Payment", 1 },
                    { 18, 771, new DateTime(2024, 2, 20, 15, 20, 15, 0, DateTimeKind.Utc), "Description for Transaction 18", "dark-bg1 icon1", "Transaction 18 for Common User", null, "Completed", "Credit", 1 },
                    { 19, 368, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1870), "Description for Transaction 19", "dark-bg2 icon1", "Transaction 19 for Common User", null, "Completed", "Credit", 1 },
                    { 21, 916, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1889), "Description for Transaction 21", "dark-bg1 icon3", "Transaction 21 for Common User", null, "Completed", "Credit", 1 },
                    { 22, 767, new DateTime(2024, 2, 5, 10, 54, 48, 0, DateTimeKind.Utc), "Description for Transaction 22", "dark-bg3 icon3", "Transaction 22 for Common User", null, "Completed", "Payment", 1 },
                    { 24, 540, new DateTime(2024, 2, 23, 21, 9, 26, 0, DateTimeKind.Utc), "Description for Transaction 24", "dark-bg3 icon3", "Transaction 24 for Common User", null, "Completed", "Payment", 1 },
                    { 25, 403, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1930), "Description for Transaction 25", "dark-bg1 icon1", "Transaction 25 for Common User", null, "Completed", "Payment", 1 },
                    { 27, 926, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1950), "Description for Transaction 27", "dark-bg1 icon3", "Transaction 27 for Common User", null, "Completed", "Payment", 1 },
                    { 28, 445, new DateTime(2024, 2, 17, 22, 49, 22, 0, DateTimeKind.Utc), "Description for Transaction 28", "dark-bg2 icon2", "Transaction 28 for Common User", null, "Pending", "Payment", 1 },
                    { 30, 383, new DateTime(2024, 2, 20, 15, 1, 43, 0, DateTimeKind.Utc), "Description for Transaction 30", "dark-bg3 icon1", "Transaction 30 for Common User", null, "Completed", "Payment", 1 }
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
                table: "CardBalances",
                columns: new[] { "Id", "CardBalanceAmount", "CardLimit", "UserId" },
                values: new object[,]
                {
                    { 1, 3.7f, 1500f, 1 },
                    { 2, 14.71f, 1500f, 2 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "ID", "TransactionAmount", "TransactionDate", "TransactionDescription", "TransactionIcon", "TransactionName", "TransactionSenderId", "TransactionStatus", "TransactionType", "UserId" },
                values: new object[,]
                {
                    { 2, 293, new DateTime(2024, 2, 9, 13, 12, 47, 0, DateTimeKind.Utc), "Description for Transaction 2", "dark-bg2 icon1", "Transaction 2 for Common User", 2, "Pending", "Credit", 1 },
                    { 5, 101, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1685), "Description for Transaction 5", "dark-bg3 icon3", "Transaction 5 for Common User", 2, "Completed", "Credit", 1 },
                    { 8, 518, new DateTime(2024, 2, 28, 4, 22, 59, 0, DateTimeKind.Utc), "Description for Transaction 8", "dark-bg1 icon3", "Transaction 8 for Common User", 2, "Completed", "Credit", 1 },
                    { 11, 948, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1752), "Description for Transaction 11", "dark-bg2 icon2", "Transaction 11 for Common User", 2, "Pending", "Payment", 1 },
                    { 14, 506, new DateTime(2024, 2, 28, 0, 5, 46, 0, DateTimeKind.Utc), "Description for Transaction 14", "dark-bg1 icon1", "Transaction 14 for Common User", 2, "Pending", "Payment", 1 },
                    { 17, 576, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1811), "Description for Transaction 17", "dark-bg2 icon3", "Transaction 17 for Common User", 2, "Completed", "Credit", 1 },
                    { 20, 583, new DateTime(2024, 2, 26, 21, 9, 47, 0, DateTimeKind.Utc), "Description for Transaction 20", "dark-bg3 icon2", "Transaction 20 for Common User", 2, "Pending", "Payment", 1 },
                    { 23, 400, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1909), "Description for Transaction 23", "dark-bg2 icon1", "Transaction 23 for Common User", 2, "Completed", "Payment", 1 },
                    { 26, 871, new DateTime(2024, 2, 16, 7, 22, 18, 0, DateTimeKind.Utc), "Description for Transaction 26", "dark-bg3 icon2", "Transaction 26 for Common User", 2, "Completed", "Payment", 1 },
                    { 29, 720, new DateTime(2024, 2, 8, 0, 47, 22, 916, DateTimeKind.Utc).AddTicks(1968), "Description for Transaction 29", "dark-bg3 icon1", "Transaction 29 for Common User", 2, "Completed", "Payment", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardBalances_UserId",
                table: "CardBalances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransactionSenderId",
                table: "Transactions",
                column: "TransactionSenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardBalances");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
