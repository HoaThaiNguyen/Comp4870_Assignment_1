using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_1.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        
        [Required]
        public string? Title { get; set; }
        
        [Required]
        public string? Body { get; set; }
        
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public string? ContributorUsername { get; set; }
    }
}
