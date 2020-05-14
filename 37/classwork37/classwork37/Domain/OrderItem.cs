using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace classwork37.Domain
{
        [Table("OrderItem", Schema = "dbo")]
        public class OrderItem
        {
            [Key]
            public int Id { get; set; }
            
            public int ProductId { get; set; }

            public int NumberOfItems { get; set; }
        }
}
