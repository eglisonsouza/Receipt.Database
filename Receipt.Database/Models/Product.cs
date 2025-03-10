namespace Receipt.Database.Models
{
    public class Product
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
        public required string Quantity { get; set; }
        public required string Unity { get; set; }
        public required string Value { get; set; }
    }
}
