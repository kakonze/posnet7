using System.ComponentModel.DataAnnotations;

namespace posnet7.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string? Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public string? Adress { get; set; } = string.Empty;
        public string? Tel { get; set; }
        public string? Pays { get; set; }


    }
}