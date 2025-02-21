using System.ComponentModel.DataAnnotations;
using Assignment_1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Assignment_1.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser, CustomRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Article>? Articles { get; set; }
        //public DbSet<CustomUser>? Users {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Use seed method here
            RoleSeeder RoleSeeder = new();
            
            builder.Entity<CustomRole>().HasData(RoleSeeder.Roles);
            builder.Entity<CustomUser>().HasData(RoleSeeder.Users);
            builder.Entity<IdentityUserRole<string>>().HasData(RoleSeeder.UserRoles);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }
}
