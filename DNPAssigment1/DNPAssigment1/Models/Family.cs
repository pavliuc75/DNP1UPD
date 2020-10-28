using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text.Json.Serialization;

namespace DNPAssigment1.Models
{
    public class Family
    {
        [JsonPropertyName("StreetName")]
        [Required] public string Address { get; set; }

        [JsonPropertyName("HouseNumber")] 
        public string HouseNumber { get; set; }
        
        [Required] public string Lastname { get; set;}
        [JsonPropertyName("Adults")]
        public List<Adult> Adults { get; set; }
        [JsonPropertyName("Children")]
        [Length(5)] public List<Child> Children { get; set; }
        public List<Pet> Pets { get; set; }
        [JsonPropertyName("ID")]
        public int Id { get; set; }
        public Family()
        {
            this.Adults = new List<Adult>();
            this.Children = new List<Child>();
            this.Pets = new List<Pet>();
        }
    }
}