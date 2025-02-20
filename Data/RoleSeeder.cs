using System;
using Assignment_1.Models;
using Microsoft.AspNetCore.Identity;

namespace Assignment_1.Data;

public class RoleSeeder
{
    private readonly List<CustomRole> _roles;
    private readonly List<CustomUser> _users;
    private readonly List<IdentityUserRole<string>> _userRoles; 
    
    public RoleSeeder() {
      _roles = GetRoles();
      _users = GetUsers();
      _userRoles = GetUserRoles(_users, _roles);
    } 

    // getters & setters
    public List<CustomRole> Roles { get { return _roles; } }
    public List<CustomUser> Users { get { return _users; } }
    public List<IdentityUserRole<string>> UserRoles { get { return _userRoles; } }
   
   private List<CustomRole> GetRoles() {
      // Seed Roles
      var adminRole = new CustomRole("Admin");
      adminRole.NormalizedName = adminRole.Name!.ToUpper();
      adminRole.Description = "Admin role";
      adminRole.CreatedDate = DateTime.Now;
      
      var memberRole = new CustomRole("Contributor");
      memberRole.NormalizedName = memberRole.Name!.ToUpper();
      memberRole.Description = "Contributor role";
      memberRole.CreatedDate = DateTime.Now;

      List<CustomRole> roles = new List<CustomRole>() {
        adminRole,
        memberRole
      };
      return roles;
    }

    private List<CustomUser> GetUsers() {
      string pwd = "P@$$w0rd";
      var passwordHasher = new PasswordHasher<CustomUser>();

      // Seed Users
      var adminUser = new CustomUser {
        UserName = "a@a.a",
        Email = "a@a.a",
        EmailConfirmed = true,
        FirstName = "Adam",
        LastName = "Anderson",
      };
      adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
      adminUser.NormalizedEmail = adminUser.Email.ToUpper();
      adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);
      
      var memberUser = new CustomUser {
        UserName = "c@c.c",
        Email = "c@c.c",
        EmailConfirmed = true,
        FirstName = "Cindy",
        LastName = "Cain",
      };
      memberUser.NormalizedUserName = memberUser.UserName.ToUpper();
      memberUser.NormalizedEmail = memberUser.Email.ToUpper();
      memberUser.PasswordHash = passwordHasher.HashPassword(memberUser, pwd);
      
      List<CustomUser> users = new List<CustomUser>() {
        adminUser,
        memberUser,
      };
      return users;
    }

    private List<IdentityUserRole<string>> GetUserRoles(List<CustomUser> users, List<CustomRole> roles) {
      // Seed UserRoles
      List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
      
      userRoles.Add(new IdentityUserRole<string> {
        UserId = users[0].Id,
        RoleId = roles.First(q => q.Name == "Admin").Id
      });
      
      userRoles.Add(new IdentityUserRole<string> {
        UserId = users[1].Id,
        RoleId = roles.First(q => q.Name == "Contributor").Id
      });
    
    return userRoles;
    }
}
