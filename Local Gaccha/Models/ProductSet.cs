#nullable disable
namespace Local_Gaccha.Models
{
    public class ProductSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set;}

    }
}
