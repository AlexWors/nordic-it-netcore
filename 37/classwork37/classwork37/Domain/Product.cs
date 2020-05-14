using System.ComponentModel.DataAnnotations.Schema;

namespace classwork37.Domain
{ 
        [Table("Product", Schema = "dbo")]
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
}
