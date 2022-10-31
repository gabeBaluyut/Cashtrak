using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CashTrak.Models
{
    public class CashRequestDbContext : DbContext
    {
        public CashRequestDbContext(DbContextOptions<CashRequestDbContext> options) : base(options)
        { }

        public DbSet<CashRequest> CashRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            myModelBuilder.Entity<CashRequest>().HasData(
                new CashRequest
                {
                    CashRequestID = 1,
                    User = "Justin",
                    Recipent = "Jason",
                    Type = "Incoming",
                    Amount = 15.99,
                    Description = "Owe me money for food man",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30)
                },
                new CashRequest
                {
                    CashRequestID = 2,
                    User = "Justin",
                    Recipent = "Gabriel",
                    Type = "Incoming",
                    Amount = 35.00,
                    Description = "Lost a bet",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30)
                },
                new CashRequest
                {
                    CashRequestID = 3,
                    User = "Justin",
                    Recipent = "Jason",
                    Type = "Outgoing",
                    Amount = 15.99,
                    Description = "Owe me money for food man",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30)
                },
                new CashRequest
                {
                    CashRequestID = 4,
                    User = "Justin",
                    Recipent = "Gabriel",
                    Type = "Outgoing",
                    Amount = 22.25,
                    Description = "Fantasy NBA payment",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30)
                }
                );
        }
    }
}
