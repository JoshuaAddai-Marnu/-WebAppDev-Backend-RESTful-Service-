using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBackEnd.Models
{
    public class Order
    {
        public int OrderId { get; set; } 
        public DateTime OrderDate { get; set; } 
        public string CustomerName { get; set; } 
        public string CustomerEmail { get; set; } 
        public string ShippingAddress { get; set; } 
        public decimal TotalAmount { get; set; } 
        public bool IsShipped { get; set; } 

        // Navigation property for OrderItems
        public List<OrderItem>? OrderItems { get; set; }
        
        // Foreign key for User
        public int UserId { get; set; }
        
        // Navigation property for User
        public User User { get; set; }
    }
}