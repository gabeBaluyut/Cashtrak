﻿// <auto-generated />
using System;
using CashTrak.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CashTrak.Migrations
{
    [DbContext(typeof(CashRequestDbContext))]
    [Migration("20221101232238_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CashTrak.Models.CashRequest", b =>
                {
                    b.Property<int>("CashRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Recipent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CashRequestID");

                    b.ToTable("CashRequests");

                    b.HasData(
                        new
                        {
                            CashRequestID = 1,
                            Amount = 15.99,
                            CreationDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Owe me money for food man",
                            DueDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Recipent = "Jason",
                            State = "Created",
                            Type = "Incoming",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 2,
                            Amount = 35.0,
                            CreationDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lost a bet",
                            DueDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Recipent = "Gabriel",
                            State = "Created",
                            Type = "Incoming",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 3,
                            Amount = 15.99,
                            CreationDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Owe me money for food man",
                            DueDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Recipent = "Jason",
                            State = "Created",
                            Type = "Outgoing",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 4,
                            Amount = 22.25,
                            CreationDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fantasy NBA payment",
                            DueDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Recipent = "Gabriel",
                            State = "Created",
                            Type = "Outgoing",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 5,
                            Amount = 15.99,
                            CreationDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Owe me money for food man",
                            DueDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Recipent = "Dave",
                            State = "Complete",
                            Type = "Incoming",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 6,
                            Amount = 35.0,
                            CreationDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lost a bet",
                            DueDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Recipent = "Donna",
                            State = "Complete",
                            Type = "Incoming",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 7,
                            Amount = 55.549999999999997,
                            CreationDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sold a pair of tic tacs for 55bucks",
                            DueDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Recipent = "Daniel",
                            State = "Complete",
                            Type = "Outgoing",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 8,
                            Amount = 16.949999999999999,
                            CreationDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Food money",
                            DueDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Recipent = "Miko",
                            State = "Complete",
                            Type = "Outgoing",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 9,
                            Amount = 5.9500000000000002,
                            CreationDate = new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Payment for homework",
                            DueDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Recipent = "Eric",
                            State = "Complete",
                            Type = "Outgoing",
                            User = "Justin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}