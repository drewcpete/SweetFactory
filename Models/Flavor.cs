using System.Collections.Generic;

namespace SweetFactory.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<FlavorTreat> Treats { get; set; }
        }
        
        public int FlavorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FlavorTreat> Treats
    }
}