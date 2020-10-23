using System.Collections.Generic;

namespace DNPAssigment1.Models
{
    public class Child : Person
    {
        public List<ChildInterest> Interests { get; set; }
        public List<Pet> Pets { get; set; }

        public Child()
        {
            this.Interests = new List<ChildInterest>();
            this.Pets = new List<Pet>();
        }
    }
}