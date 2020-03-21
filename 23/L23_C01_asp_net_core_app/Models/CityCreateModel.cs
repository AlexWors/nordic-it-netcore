using System.ComponentModel.DataAnnotations;
using L23_C01_asp_net_core_app.Data;
using L23_C01_asp_net_core_app.Validation;

namespace L23_C01_asp_net_core_app.Models
{
	public class CityCreateModel
	{ 
		[Required]
		[MinLength(2)]
		[MaxLength(100)]
		//Обязательное поле
		//ограничено по длине 100
		public string Name { get; set; }
		//Обязательное поле
		//ограничено по длине 300
		
		[MaxLength(300)]
		[DifferentValue("Name")]
		public string Description { get; set; }


		public CityCreateModel()
		{
		}

		public CityCreateModel(CityDto city)
		{
			Name = city.Name;
			Description = city.Description;
		}

		public CityDto ToDto(int id)
		{
			var dto = new CityDto
			{
				Id = id,
				Name = Name,
				Description = Description
			};

			return dto;
		}
	}
}
