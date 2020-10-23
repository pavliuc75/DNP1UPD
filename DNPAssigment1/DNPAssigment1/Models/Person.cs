using System.ComponentModel.DataAnnotations;

namespace DNPAssigment1.Models
{
    public abstract class Person
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        public int Id { get; set; }
        
        public HairColor HairColor { get; set; } 
        public EyeColor EyeColor { get; set; }
        [Required, Range(0,100)]
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
    }
}