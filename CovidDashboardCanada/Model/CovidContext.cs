using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidDashboardCanada.Model
{
    public class CovidContext : DbContext
    {
        public DbSet<DailyCaseRecord> Confirmed { get; set; }
        public DbSet<DailyCaseRecord> Recovered { get; set; }
        public DbSet<DailyCaseRecord> Deaths { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(DatabaseHelper.CONNECTION_STRING);
        }
    }
}
