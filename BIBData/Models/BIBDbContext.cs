using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIBData.Models
{
    public class BIBDbContext : DbContext
    {
        public DbSet<Lener> Leners { get; set; }
        public DbSet<Uitleenobject> Uitleenobjecten { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Boek> Boeken { get; set; }
        public DbSet<Reservering> Reserveringen { get; set; }
        public DbSet<Uitlening> Uitleningen { get; set; }
        public DbSet<OperatingSysteem> Operatingsystemen { get; set; }

        public BIBDbContext() { }
        public BIBDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("BIBConnection"));
        }
    }
}
