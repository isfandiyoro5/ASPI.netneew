using System.ComponentModel.DataAnnotations;

namespace IntroAPI.Models
{
    public class Customers
    {
        [Required]
        [Key]
        public short CustomerID { get; set; }
        [Required]
        [MinLength(3)]
        public string CustomerFirstName { get; set; }
        public string CustomerLasName { get; set; }
    }
}
