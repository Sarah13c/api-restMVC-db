﻿using Microsoft.EntityFrameworkCore;
using PricatMVC.Models;

namespace PricatMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Products> Products { get; set; }
    }
}
