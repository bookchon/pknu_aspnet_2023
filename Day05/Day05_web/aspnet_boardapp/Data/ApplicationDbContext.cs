﻿using aspnet_boardapp.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_boardapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
    }
}
