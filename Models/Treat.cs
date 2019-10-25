using System.Collections.Generic;

namespace SweetFactory
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<FlavorItem>();
        }
        public int TreatID { get; set; }
        public string TreatName { get; set; }
        public virtual ApplicationUser User { get; set; }
        
        public ICollection<FlavorItem> Flavors { get; }
    }
}