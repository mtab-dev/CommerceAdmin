namespace CommerceAdmin.API.Entities
{
    public class ProductEntity
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string sku { get; set; } = string.Empty;
        public string category { get; set; } = string.Empty;
        public decimal price { get; set; }
        public List<string> imagesUrl { get; set; } = new List<string>();
        public int stock { get; set; } 
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
    }
}
