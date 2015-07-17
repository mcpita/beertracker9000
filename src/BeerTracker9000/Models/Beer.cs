namespace BeerTracker9000.Models
{
    public class Beer
    {
        public decimal ABV;
        public string Name { get; set; }
        public BeerTypes Type { get; set; }
        public string Brewery { get; set; }
        public string Description { get; set; }
    }
}