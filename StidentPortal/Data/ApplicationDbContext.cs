﻿using Microsoft.EntityFrameworkCore;
using StidentPortal.Models.Entities;

namespace StidentPortal.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
