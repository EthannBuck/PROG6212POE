using System;
using System.ComponentModel.DataAnnotations;

namespace PROGPART1.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public string Status { get; set; } // Pending, Approved, Rejected

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
