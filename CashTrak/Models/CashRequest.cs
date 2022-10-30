using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashTrak.Models
{
    public class CashRequest
    {

        public int CashRequestID { get; set; }

        public string User { get; set; }

        public string Recipent { get; set; }

        public string Type { get; set; }

        public double Amount { get; set; }

        public string? Description { get; set; }

    }
}
