using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace WebApp.Models
{
    [Table("Products", Schema = "Webappdb")]
    public class Product
    { 
        public int Id { get; set; }
        [Required]
        public int Article { get; set; }
        [Required]
        public string Name { get; set; }

        //[DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }
    }
}
