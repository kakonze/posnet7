using System.ComponentModel.DataAnnotations;

namespace posnet7.Models
{
    public class Sale
    {
        public int ID { get; set; }
        public string? ItemName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime SaleDate { get; set; }
        public int Quant { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal Tax { get; set; }
    }
}