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
                    Username = "Justin",
                    Money = 15.99,
                    Description = "Owe me money for food man"
                }
                );
        }
    }
}
