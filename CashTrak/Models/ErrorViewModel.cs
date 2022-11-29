using System;

/// <summary>
/// Error Model
/// Defines the model for an error
/// 
/// Author: Justin Payne, Gabriel Baluyut, Jason Cheung
/// Date: Nov 28 2022
/// Sources: Lab 6 Implement Authentication and Authorization
/// </summary>
namespace CashTrak.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
