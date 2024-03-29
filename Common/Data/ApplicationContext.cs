using Entites.Models;
using Microsoft.EntityFrameworkCore;

namespace Common.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options) {}

        public virtual DbSet<IssuingCompany> IssuingCompanies { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<ActiveType> ActiveTypes { get; set; }
        public virtual DbSet<Exchange> Exchanges { get; set; }
        public virtual DbSet<CurrencyType> CurrencyTypes { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}