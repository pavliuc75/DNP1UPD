﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DNPAssigment1.Models;

namespace Models {
    public class Family {
        
        [Required]
        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }
        [Required]
        [JsonPropertyName("houseNumber")]
        public int HouseNumber{ get; set; }
        [JsonPropertyName("adults")]
        public List<Adult> Adults { get; set; }
        [JsonPropertyName("children")]
        public List<Child> Children{ get; set; }
        [JsonPropertyName("pets")]
        public List<Pet> Pets{ get; set; }

        public Family() {
            Adults = new List<Adult>();     
        }

    }


}