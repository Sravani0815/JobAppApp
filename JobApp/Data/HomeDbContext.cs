using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobApp.Models;

namespace JobApp.Data
{
    public class HomeDbContext : DbContext
    {
        public HomeDbContext (DbContextOptions<HomeDbContext> options)
            : base(options)
        {
        }

        public DbSet<JobApp.Models.House> House { get; set; } = default!;
    }
}
