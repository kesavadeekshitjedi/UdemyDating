﻿using Microsoft.EntityFrameworkCore;

using UdemyDating.WebAPI.Models;

namespace UdemyDating.WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<AppUser> Users { get; set; }
    }
}
