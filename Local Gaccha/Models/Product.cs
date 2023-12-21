#nullable disable
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Local_Gaccha.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Sku { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        public string Type { get; set; }

        [Required]
        public int ProductSetId { get; set; }
        [JsonIgnore]
        public virtual ProductSet ProductSet { get; set; }

    }
}
