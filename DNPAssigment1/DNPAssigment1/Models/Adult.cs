using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace DNPAssigment1.Models
{
    public class Adult : Person
    {
        [JsonPropertyName("JobTitle")]
         public Job Job { get; set; }
    }
}