#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using efQuize.Api.Models;

    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<efQuize.Api.Models.Genre> Genre { get; set; }

        public DbSet<efQuize.Api.Models.Questions> Questions { get; set; }

        public DbSet<efQuize.Api.Models.Answers> Answers { get; set; }
    }
