using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashTrak.Models
{
    public class CashRequest
    {

        public int CashRequestID { get; set; }

        public string Username { get; set; }

        public double Money { get; set; }

        public string? Description { get; set; }
    }
}
