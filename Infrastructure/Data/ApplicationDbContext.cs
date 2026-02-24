using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Asset> Assets { get; set;}
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Budget> Budgets{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Liability> Liabilities { get; set; }
        public DbSet<Account> Accounts { get; set; }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Liability entity
            modelBuilder.Entity<Liability>()
                .Property(l => l.Value)
                .HasPrecision(18, 2);

            // Configure Account entity
            modelBuilder.Entity<Account>()
                .Property(a => a.Balance)
                .HasPrecision(18, 2);
        }
    }
}