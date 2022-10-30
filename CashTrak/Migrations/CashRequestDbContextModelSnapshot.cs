﻿// <auto-generated />
using CashTrak.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CashTrak.Migrations
{
    [DbContext(typeof(CashRequestDbContext))]
    partial class CashRequestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

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
                            Description = "Owe me money for food man",
                            Recipent = "Jason",
                            Type = "Incoming",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 2,
                            Amount = 35.0,
                            Description = "Lost a bet",
                            Recipent = "Gabriel",
                            Type = "Incoming",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 3,
                            Amount = 15.99,
                            Description = "Owe me money for food man",
                            Recipent = "Jason",
                            Type = "Outgoing",
                            User = "Justin"
                        },
                        new
                        {
                            CashRequestID = 4,
                            Amount = 22.25,
                            Description = "Fantasy NBA payment",
                            Recipent = "Gabriel",
                            Type = "Outgoing",
                            User = "Justin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
