﻿using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; } 
    }
}
