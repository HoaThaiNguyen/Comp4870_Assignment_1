using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_1.Models;

public class ContributorApprovalViewModel
{
    public int ApprovalId { get; set; }

    [Required]
    public string? Email { get; set; }
}
