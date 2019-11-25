using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Models
{
    public class Evaluation
    {
        public long EvaluationId { get; set; }
        public decimal MoodRating { get; set; }
        public decimal Price { get; set; }
        public decimal Experience { get; set; } 
        public long UserId { get; set; }
        public long RestaurantId { get; set; }
    }
}
