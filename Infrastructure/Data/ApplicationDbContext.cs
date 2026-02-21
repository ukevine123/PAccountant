using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Liability> Liabilities { get; set; }
         
        //  protected override void OnModelCreating(ModelBuilder Builder)
        // {
        //     base.OnModelCreating(Builder);

        //     // customize Identity tables
        //     Builder.Entity<User>().ToTable("Users");
        //      Builder.Entity<IdentityRole<int>>().ToTable("Roles");
        //         Builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
        //         Builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
        //         Builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
        //         Builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");
        //         Builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles").HasKey(ur => new { ur.UserId, ur.RoleId });
                

            

           
        // }
        
        
        
    }
}