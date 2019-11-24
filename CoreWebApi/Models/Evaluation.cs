using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    [Table("Evaluation")]
    public class Evaluation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EvaluationId { get; set; }

        [Required]
        [Column(TypeName = "decimal(4,2)")]
        public decimal MoodRating { get; set; }

        [Required]
        [Column(TypeName = "decimal(4,2)")]
        public decimal Price { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(4,2)")]
        public decimal Experience { get; set; }
        
        [ForeignKey(nameof(User))]
        public long UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Restaurant))]
        public long RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
