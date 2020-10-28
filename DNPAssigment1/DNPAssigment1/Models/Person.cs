using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DNPAssigment1.Models
{
    public abstract class Person
    {
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }
        [JsonPropertyName("ID")]
        public int Id { get; set; }
        
        [JsonPropertyName("HairColor")]
        public HairColor HairColor { get; set; } 
        [JsonPropertyName("EyeColor")]
        public EyeColor EyeColor { get; set; }
        [JsonPropertyName("Age")]
        public int Age { get; set; }
        [JsonPropertyName("Weight")]
        public int Weight { get; set; }
        [JsonPropertyName("Height")]
        public int Height { get; set; }
        [JsonPropertyName("Sex")]
        public string Sex { get; set; }
    }
}