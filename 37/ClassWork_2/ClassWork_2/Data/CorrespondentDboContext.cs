using ClassWork_2.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_2.Data
{
    class CorrespondentDboContext : DbContext
    {
        private string _connectionString =
            @"Data Source=desktop-5gcn8t1\sqlexpress;" +
            "Initial Catalog=CorrespondenceEFCore;" +
            "Integrated Security=true;";

        public DbSet<City> Citys { get; set; }

        public DbSet<Office> Offices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
