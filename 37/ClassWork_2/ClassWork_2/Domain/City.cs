using System.ComponentModel.DataAnnotations;

namespace ClassWork_2.Domain
{
    class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
