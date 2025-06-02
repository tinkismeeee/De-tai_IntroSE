namespace DO_AN.Models
{
    public class Accessory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Price {  get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }

    }
}