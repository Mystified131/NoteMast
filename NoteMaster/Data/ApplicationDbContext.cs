﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoteMaster.Models;

namespace NoteMaster.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Note> Notes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
