using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassWork_2.Domain
{
    class Office
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("cityId")]
        public int CityId { get; set; }

        public City City { get; set; }

        public string Adress { get; set; }
    }
}
