using System.ComponentModel.DataAnnotations;

namespace DNPAssigment1.Models
{
    public class Pet
    {
        public PetSpecies Species;

        [Required]
        [MaxLength(128, ErrorMessage = "The value should be 1-128 symbols")]
        public string Name { get; set; }

        [Required]
        [Range(0, 50, ErrorMessage = "The value should be between 0-50")]
        public int Age { get; set; }
    }
}