using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

/// <summary>
/// User Model
/// Defines the model for a User
/// 
/// Author: Justin Payne, Gabriel Baluyut, Jason Cheung
/// Date: Nov 28 2022
/// Sources: Lab 6 Implement Authentication and Authorization
/// </summary>
namespace CashTrak.Models
{
    /// <summary>
    /// Inherits all user identity characteristics
    /// </summary>
    public class User : IdentityUser
    {
        [NotMapped]
        public IList<string> RoleNames { get; set; }

    }
}
