using System.Collections.Generic;

namespace SweetFactory.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<FlavorTreat>();
        }
        
        public int FlavorID { get; set; }
        public string FlavorName { get; set; }
        public virtual ICollection<FlavorTreat> Treats { get; set; }
    }
}