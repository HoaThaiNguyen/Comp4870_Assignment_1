using Assignment_1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Assignment_1.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Use seed method here
            RoleSeeder seedUsersRoles = new();
            
            builder.Entity<CustomRole>().HasData(seedUsersRoles.Roles);
            builder.Entity<CustomUser>().HasData(seedUsersRoles.Users);
            builder.Entity<IdentityUserRole<string>>().HasData(seedUsersRoles.UserRoles);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ContributorApproval> ContributorApprovals {get; set;}
    }

    public class ContributorApproval
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public bool IsApproved { get; set; }
    }
}
