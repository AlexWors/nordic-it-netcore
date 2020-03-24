using CitiesData.Core;
using L23_C01_asp_net_core_app.Validation;
using System.ComponentModel.DataAnnotations;

namespace L23_C01_asp_net_core_app.Models
{
	public class CityReplaceModel
	{
		[Required]
		[MinLength(2)]
		[MaxLength(100)]
		public string Name { get; set; }

		[MaxLength(300)]
		[DifferentValue("Name")]
		public string Description { get; set; }

		public CityReplaceModel()
		{
		}

		public CityReplaceModel(CityDto city)
		{
			Name = city.Name;
			Description = city.Description;
		}
	}
}
