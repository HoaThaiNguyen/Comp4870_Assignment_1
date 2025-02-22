using System;
using Assignment_1.Controllers;
using Assignment_1.Models;
using Microsoft.AspNetCore.Identity;

namespace Assignment_1.Data;

public class SeedData
{
    private readonly List<CustomRole> _roles;
    private readonly List<CustomUser> _users;
    private readonly List<IdentityUserRole<string>> _userRoles; 
    private readonly List<Article> _articles;
    
    public SeedData() {
      _roles = GetRoles();
      _users = GetUsers();
      _userRoles = GetUserRoles(_users, _roles);
      _articles = GetArticles();
    } 

    // getters & setters
    public List<CustomRole> Roles { get { return _roles; } }
    public List<CustomUser> Users { get { return _users; } }
    public List<IdentityUserRole<string>> UserRoles { get { return _userRoles; } }
    public List<Article> Articles { get { return _articles; } }

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
        Password = pwd,
        IsApproved = true,
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
        Password = pwd,
        IsApproved = true,
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
      
      userRoles.Add(new IdentityUserRole<string> 
      {
        UserId = users[0].Id,
        RoleId = roles.First(q => q.Name == "Admin").Id
      });
      
      userRoles.Add(new IdentityUserRole<string> {
        UserId = users[1].Id,
        RoleId = roles.First(q => q.Name == "Contributor").Id
      });
    
    return userRoles;
    }

    private List<Article> GetArticles() {
      List<Article> articles = new List<Article>();

      var startDate = DateTime.UtcNow.ToLocalTime();

      articles.Add(new Article
      {
        ArticleId = 1,
        Title = "Charli XCX Brings 'Brat' To The 2025 GRAMMYs",
        Body = "Charli xcx turned Crypto.com Arena into a rave at the "
             + "2025 GRAMMYs, where she delivered a wild live performance " 
             + "of 'Von dutch' and 'Guess' from her GRAMMY-winning album " 
             + " brat. \n\n Charlie walked into the 67th Annual GRAMMY "
             + "Awards as one of the night's most-nominated artists, "
             + "earning eight nominations in total. She ended the night "
             + "with three wins, including Best Dance Pop Recording (“Von "
             + "dutch”), Best Dance/Electronic Album (BRAT)and Best "
             + "Recording Package (BRAT).",
        CreateDate = startDate,
        StartDate = startDate,
        EndDate = startDate.AddDays(7),
        ContributorUsername = "c@c.c",
      });

      return articles;
    }
}
