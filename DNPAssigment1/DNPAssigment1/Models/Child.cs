using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DNPAssigment1.Models
{
    public class Child : Person
    {
        [JsonPropertyName("ChildInterests")]
        public List<ChildInterest> Interests { get; set; }
        [JsonPropertyName("Pets")]
        public List<Pet> Pets { get; set; }
        
        public Child()
        {
            this.Interests = new List<ChildInterest>();
            this.Pets = new List<Pet>();
        }
    }
}