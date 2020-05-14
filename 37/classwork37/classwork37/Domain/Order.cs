using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace classwork37.Domain
{
    [Table("Order", Schema = "dbo")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public decimal Discount { get; set; }
    }
    
}
