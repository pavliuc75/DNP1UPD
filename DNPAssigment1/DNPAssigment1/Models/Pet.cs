using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DNPAssigment1.Models
{
    public class Pet
    {
        public PetSpecies Species;

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Age")]
        public int Age { get; set; }
    }
}