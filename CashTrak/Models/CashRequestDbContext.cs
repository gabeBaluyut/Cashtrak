using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CashTrak.Models
{
    public class CashRequestDbContext : IdentityDbContext<IdentityUser>
    {
        public CashRequestDbContext(DbContextOptions<CashRequestDbContext> options) : base(options)
        { }

        public DbSet<CashRequest> CashRequests { get; set; }

        //public DbSet<User> Recipient { get; set; }

        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);
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
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Created"
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
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Created"
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
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Created"
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
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Created"
                },
                new CashRequest
                {
                    CashRequestID = 5,
                    User = "Justin",
                    Recipent = "Dave",
                    Type = "Incoming",
                    Amount = 15.99,
                    Description = "Owe me money for food man",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Complete"
                },
                new CashRequest
                {
                    CashRequestID = 6,
                    User = "Justin",
                    Recipent = "Donna",
                    Type = "Incoming",
                    Amount = 35.00,
                    Description = "Lost a bet",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Complete"
                },
                new CashRequest
                {
                    CashRequestID = 7,
                    User = "Justin",
                    Recipent = "Daniel",
                    Type = "Outgoing",
                    Amount = 55.55,
                    Description = "Sold a pair of tic tacs for 55bucks",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Complete"
                },
                new CashRequest
                {
                    CashRequestID = 8,
                    User = "Justin",
                    Recipent = "Miko",
                    Type = "Outgoing",
                    Amount = 16.95,
                    Description = "Food money",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Complete"
                },
                new CashRequest
                {
                    CashRequestID = 9,
                    User = "Justin",
                    Recipent = "Eric",
                    Type = "Outgoing",
                    Amount = 5.95,
                    Description = "Payment for homework",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Complete"
                }
                );
        }
    }
}
