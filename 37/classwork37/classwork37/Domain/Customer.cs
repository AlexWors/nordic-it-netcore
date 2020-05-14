using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace classwork37.Domain
{
        [Table("Order", Schema = "dbo")]
        public class Customer
        {
            [Key]
            public int Id { get; set; }
            
            [Required]
            [MaxLength(50)]
            public string Name { get; set; }
        }
}
