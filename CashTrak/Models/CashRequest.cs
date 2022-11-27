using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CashTrak.Models
{
    public enum TypeList {
        Incoming,
        Outgoing
    }
    public class CashRequest
    {

        public int CashRequestID { get; set; }

        public string User { get; set; }

        public string Recipent { get; set; }

        public string Type { get; set; }

        public double Amount { get; set; }

        //#nullable enable
        public string? Description { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime CreationDate { get; set; }

        public string State { get; set; }

        public string CompletionRequestUser { get; set; }

    }
}
