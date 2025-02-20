using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Assignment_1.Models;

public class CustomUser : IdentityUser {
  public CustomUser() : base() { }

  [Required]
  public string? FirstName { get; set; }
  
  [Required]
  public string? LastName { get; set; }
}
