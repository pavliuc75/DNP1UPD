using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;

namespace DNPAssigment1.Models
{
    public class Family
    {
        [Required] public string Address { get; set; }
        [Required] public string Lastname { get; set; }
        [Length(2)] public List<Adult> Adults { get; set; }

        [Length(5)] public List<Child> Children { get; set; }
        public List<Pet> Pets { get; set; }
        public int Id { get; set; }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public Family()
        {
            this.Adults = new List<Adult>();
            this.Children = new List<Child>();
            this.Pets = new List<Pet>();
            this.Address = "UNKNOWN";
            this.Lastname = RandomString(5);
        }
    }
}