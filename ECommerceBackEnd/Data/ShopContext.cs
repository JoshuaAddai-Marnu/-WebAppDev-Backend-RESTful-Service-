using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBackEnd.Data
{
    public class ShopContext : DbContext
    {
        
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> products{get; set;}
        public DbSet<Supplier> suppliers{get; set;}
        public DbSet<User> users{get; set;}
    }
}