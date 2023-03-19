using System.ComponentModel.DataAnnotations;

namespace posnet7.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string? ProdName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public string? Category { get; set; } = string.Empty;
        public int Quant { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
    }
}