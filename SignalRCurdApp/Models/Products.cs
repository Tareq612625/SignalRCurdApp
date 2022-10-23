using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRCurdApp.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Catagory { get; set; }
        public decimal ProductPrice { get; set; }
        public int StockQty { get; set; }
    }
}
