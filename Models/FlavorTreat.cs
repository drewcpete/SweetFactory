namespace SweetFactory.Models
{
    public class FlavorItem
    {
        public int FlavorItemID { get; set; }
        public int TreatID { get; set; }
        public int FlavorID { get; set; }
        public Flavor Flavor { get; set; }
        public Treat Treat { get; set; }
    }
}