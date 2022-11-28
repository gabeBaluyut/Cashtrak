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
                    Recipent = "Ceddybu",
                    Type = "Incoming",
                    Amount = 15.99,
                    Description = "Owe me money for food man",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Created",
                    CompletionRequestUser = null
                },
                new CashRequest
                {
                    CashRequestID = 2,
                    User = "Ceddybu",
                    Recipent = "Justin",
                    Type = "Outgoing",
                    Amount = 35.00,
                    Description = "Lost a bet",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Created",
                    CompletionRequestUser = null
                },
                new CashRequest
                {
                    CashRequestID = 3,
                    User = "Justin",
                    Recipent = "Ceddybu",
                    Type = "Incoming",
                    Amount = 15.99,
                    Description = "Owe me money for food man",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Accepted",
                    CompletionRequestUser = null
                },
                new CashRequest
                {
                    CashRequestID = 4,
                    User = "Ceddybu",
                    Recipent = "Justin",
                    Type = "Outgoing",
                    Amount = 22.25,
                    Description = "Fantasy NBA payment",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Accepted",
                    CompletionRequestUser = null
                },
                new CashRequest
                {
                    CashRequestID = 5,
                    User = "Justin",
                    Recipent = "Ceddybu",
                    Type = "Incoming",
                    Amount = 15.99,
                    Description = "Owe me money for food man",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Sent",
                    CompletionRequestUser = "Justin"
                },
                new CashRequest
                {
                    CashRequestID = 6,
                    User = "Justin",
                    Recipent = "Ceddybu",
                    Type = "Outgoing",
                    Amount = 35.00,
                    Description = "Lost a bet",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Sent",
                    CompletionRequestUser = "Ceddybu"
                },
                new CashRequest
                {
                    CashRequestID = 7,
                    User = "Justin",
                    Recipent = "Ceddybu",
                    Type = "Outgoing",
                    Amount = 55.55,
                    Description = "Sold a pair of tic tacs for 55bucks",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Complete",
                    CompletionRequestUser = "Justin"
                },
                new CashRequest
                {
                    CashRequestID = 8,
                    User = "Ceddybu",
                    Recipent = "Justin",
                    Type = "Outgoing",
                    Amount = 16.95,
                    Description = "Food money",
                    DueDate = new DateTime(2022, 10, 31),
                    CreationDate = new DateTime(2022, 10, 30),
                    State = "Complete",
                    CompletionRequestUser = "Ceddybu"
                }
                );
        }
    }
}
