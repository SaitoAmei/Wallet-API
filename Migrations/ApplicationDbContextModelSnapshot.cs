﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Wallet_API.Data;

#nullable disable

namespace Wallet_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Wallet_API.Data.DbModels.Transaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("TransactionAmount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TransactionDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TransactionIcon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TransactionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TransactionSenderId")
                        .HasColumnType("integer");

                    b.Property<string>("TransactionStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("TransactionSenderId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            ID = 2,
                            TransactionAmount = 872,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8767),
                            TransactionDescription = "Description for Transaction 2",
                            TransactionIcon = "dark-bg3 icon1",
                            TransactionName = "Transaction 2 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Pending",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 3,
                            TransactionAmount = 324,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8783),
                            TransactionDescription = "Description for Transaction 3",
                            TransactionIcon = "dark-bg3 icon1",
                            TransactionName = "Transaction 3 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Payment",
                            UserId = 1
                        },
                        new
                        {
                            ID = 4,
                            TransactionAmount = 212,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8835),
                            TransactionDescription = "Description for Transaction 4",
                            TransactionIcon = "dark-bg2 icon1",
                            TransactionName = "Transaction 4 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Payment",
                            UserId = 1
                        },
                        new
                        {
                            ID = 5,
                            TransactionAmount = 472,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8850),
                            TransactionDescription = "Description for Transaction 5",
                            TransactionIcon = "dark-bg2 icon1",
                            TransactionName = "Transaction 5 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 6,
                            TransactionAmount = 312,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8855),
                            TransactionDescription = "Description for Transaction 6",
                            TransactionIcon = "dark-bg1 icon2",
                            TransactionName = "Transaction 6 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 7,
                            TransactionAmount = 239,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8864),
                            TransactionDescription = "Description for Transaction 7",
                            TransactionIcon = "dark-bg2 icon2",
                            TransactionName = "Transaction 7 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 8,
                            TransactionAmount = 492,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8869),
                            TransactionDescription = "Description for Transaction 8",
                            TransactionIcon = "dark-bg1 icon1",
                            TransactionName = "Transaction 8 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 9,
                            TransactionAmount = 812,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8878),
                            TransactionDescription = "Description for Transaction 9",
                            TransactionIcon = "dark-bg3 icon3",
                            TransactionName = "Transaction 9 for Common User",
                            TransactionStatus = "Pending",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 10,
                            TransactionAmount = 502,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8883),
                            TransactionDescription = "Description for Transaction 10",
                            TransactionIcon = "dark-bg3 icon1",
                            TransactionName = "Transaction 10 for Common User",
                            TransactionStatus = "Pending",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 11,
                            TransactionAmount = 332,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8890),
                            TransactionDescription = "Description for Transaction 11",
                            TransactionIcon = "dark-bg3 icon3",
                            TransactionName = "Transaction 11 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Completed",
                            TransactionType = "Payment",
                            UserId = 1
                        },
                        new
                        {
                            ID = 12,
                            TransactionAmount = 436,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8896),
                            TransactionDescription = "Description for Transaction 12",
                            TransactionIcon = "dark-bg2 icon1",
                            TransactionName = "Transaction 12 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 13,
                            TransactionAmount = 944,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8903),
                            TransactionDescription = "Description for Transaction 13",
                            TransactionIcon = "dark-bg1 icon1",
                            TransactionName = "Transaction 13 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 14,
                            TransactionAmount = 732,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8908),
                            TransactionDescription = "Description for Transaction 14",
                            TransactionIcon = "dark-bg3 icon3",
                            TransactionName = "Transaction 14 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Pending",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 15,
                            TransactionAmount = 789,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8913),
                            TransactionDescription = "Description for Transaction 15",
                            TransactionIcon = "dark-bg1 icon3",
                            TransactionName = "Transaction 15 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 16,
                            TransactionAmount = 690,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8918),
                            TransactionDescription = "Description for Transaction 16",
                            TransactionIcon = "dark-bg1 icon1",
                            TransactionName = "Transaction 16 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Payment",
                            UserId = 1
                        },
                        new
                        {
                            ID = 17,
                            TransactionAmount = 808,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8925),
                            TransactionDescription = "Description for Transaction 17",
                            TransactionIcon = "dark-bg1 icon2",
                            TransactionName = "Transaction 17 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 18,
                            TransactionAmount = 270,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8930),
                            TransactionDescription = "Description for Transaction 18",
                            TransactionIcon = "dark-bg2 icon1",
                            TransactionName = "Transaction 18 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Payment",
                            UserId = 1
                        },
                        new
                        {
                            ID = 19,
                            TransactionAmount = 478,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8936),
                            TransactionDescription = "Description for Transaction 19",
                            TransactionIcon = "dark-bg1 icon1",
                            TransactionName = "Transaction 19 for Common User",
                            TransactionStatus = "Pending",
                            TransactionType = "Payment",
                            UserId = 1
                        },
                        new
                        {
                            ID = 20,
                            TransactionAmount = 917,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8941),
                            TransactionDescription = "Description for Transaction 20",
                            TransactionIcon = "dark-bg1 icon2",
                            TransactionName = "Transaction 20 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 21,
                            TransactionAmount = 370,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8947),
                            TransactionDescription = "Description for Transaction 21",
                            TransactionIcon = "dark-bg3 icon2",
                            TransactionName = "Transaction 21 for Common User",
                            TransactionStatus = "Pending",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 22,
                            TransactionAmount = 509,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8952),
                            TransactionDescription = "Description for Transaction 22",
                            TransactionIcon = "dark-bg1 icon3",
                            TransactionName = "Transaction 22 for Common User",
                            TransactionStatus = "Pending",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 23,
                            TransactionAmount = 193,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8993),
                            TransactionDescription = "Description for Transaction 23",
                            TransactionIcon = "dark-bg3 icon3",
                            TransactionName = "Transaction 23 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 24,
                            TransactionAmount = 530,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(8998),
                            TransactionDescription = "Description for Transaction 24",
                            TransactionIcon = "dark-bg1 icon2",
                            TransactionName = "Transaction 24 for Common User",
                            TransactionStatus = "Pending",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 25,
                            TransactionAmount = 216,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9005),
                            TransactionDescription = "Description for Transaction 25",
                            TransactionIcon = "dark-bg1 icon3",
                            TransactionName = "Transaction 25 for Common User",
                            TransactionStatus = "Pending",
                            TransactionType = "Payment",
                            UserId = 1
                        },
                        new
                        {
                            ID = 26,
                            TransactionAmount = 642,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9010),
                            TransactionDescription = "Description for Transaction 26",
                            TransactionIcon = "dark-bg3 icon1",
                            TransactionName = "Transaction 26 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Pending",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 27,
                            TransactionAmount = 474,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9015),
                            TransactionDescription = "Description for Transaction 27",
                            TransactionIcon = "dark-bg1 icon1",
                            TransactionName = "Transaction 27 for Common User",
                            TransactionStatus = "Pending",
                            TransactionType = "Payment",
                            UserId = 1
                        },
                        new
                        {
                            ID = 28,
                            TransactionAmount = 815,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9019),
                            TransactionDescription = "Description for Transaction 28",
                            TransactionIcon = "dark-bg3 icon3",
                            TransactionName = "Transaction 28 for Common User",
                            TransactionStatus = "Pending",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 29,
                            TransactionAmount = 359,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9025),
                            TransactionDescription = "Description for Transaction 29",
                            TransactionIcon = "dark-bg1 icon1",
                            TransactionName = "Transaction 29 for Common User",
                            TransactionSenderId = 2,
                            TransactionStatus = "Completed",
                            TransactionType = "Credit",
                            UserId = 1
                        },
                        new
                        {
                            ID = 30,
                            TransactionAmount = 772,
                            TransactionDate = new DateTime(2024, 2, 7, 21, 46, 17, 708, DateTimeKind.Utc).AddTicks(9030),
                            TransactionDescription = "Description for Transaction 30",
                            TransactionIcon = "dark-bg3 icon2",
                            TransactionName = "Transaction 30 for Common User",
                            TransactionStatus = "Completed",
                            TransactionType = "Payment",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Wallet_API.Data.DbModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Name = "Common User"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("Wallet_API.Data.DbModels.Transaction", b =>
                {
                    b.HasOne("Wallet_API.Data.DbModels.User", "TransactionSender")
                        .WithMany("SentTransactions")
                        .HasForeignKey("TransactionSenderId");

                    b.Navigation("TransactionSender");
                });

            modelBuilder.Entity("Wallet_API.Data.DbModels.User", b =>
                {
                    b.Navigation("SentTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
