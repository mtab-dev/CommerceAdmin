using System.ComponentModel.DataAnnotations;

namespace CommerceAdmin.Application.DTO.Request
{
    public record RegisterProductDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Sku { get; set; } = string.Empty;
        [Required]
        public string Category { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public List<string> ImagesUrl { get; set; } = new List<string>();
        [Required]
        public int Stock { get; set; }

    }
}
