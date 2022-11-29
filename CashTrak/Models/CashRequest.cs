using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// CashRequest Model
/// Defines the model for a cash request
/// 
/// Author: Justin Payne, Gabriel Baluyut, Jason Cheung
/// Date: Nov 28 2022
/// Sources: Lab 4 MovieStore
/// Sources: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
/// </summary>
namespace CashTrak.Models
{
    /// <summary>
    /// Enum variables for the type of cash requests created
    /// </summary>
    public enum TypeList {
        Incoming,
        Outgoing
    }

    /// <summary>
    /// Enum variables for the valid states of a cash request
    /// </summary>
    public enum CashRequestState
    {
        Created,
        Accepted,
        Sent,
        Completed
    }

    /// <summary>
    /// Cash Request model
    /// Missing: Validation
    /// </summary>
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
