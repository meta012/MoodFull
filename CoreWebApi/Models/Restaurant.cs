using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    [Table("Restaurant")]
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RestaurantId { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [StringLength(150, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; }
        [StringLength(400)]
        public string Url { get; set; }
        [StringLength(100)]
        public string Type { get; set; }
        [StringLength(200)]
        public string Street { get; set; }
        [StringLength(200)]
        public string SpecifyStreet { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public ICollection<Evaluation> Evaluations { get; set; }
    }
}
