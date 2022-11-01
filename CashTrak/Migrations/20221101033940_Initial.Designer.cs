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
<<<<<<<< HEAD:CashTrak/Migrations/20221101033940_Initial.Designer.cs
    [Migration("20221101033940_Initial")]
    partial class Initial
========
    [Migration("20221031020431_Initalize")]
    partial class Initalize
>>>>>>>> gabriel:CashTrak/Migrations/20221031020431_Initalize.Designer.cs
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
                            Type = "Outgoing",
                            User = "Justin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
