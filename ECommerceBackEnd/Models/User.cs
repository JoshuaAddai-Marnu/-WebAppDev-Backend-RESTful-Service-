using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ECommerceBackEnd.Models
{
    public class User : IdentityUser
    {
        public int UserId { get; set; } 
        public string? Username { get; set; } 
         
        public bool IsAdmin { get; set; } // Flag indicating whether the user has admin privileges
        // Additional properties as needed

        // Navigation property for Orders
        public List<Order>? Orders { get; set; }
    }
}