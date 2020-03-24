using System.Collections.Generic;
using CitiesData.Core;

namespace CitiesData.InMemory
{
	public class CitiesDataStore : ICItiesDataStore
	{
		public List<CityDto> Cities { get; }

		public CitiesDataStore()
		{
			Cities = new List<CityDto>
			{
				new CityDto(1, "Moscow", "The capital of our Motherland"),
				new CityDto(2, "Saint-Petersburg", "the city I am originally from"),
				new CityDto(3, "New-York", "The city I would like to take a look at :)")
			};
		}
	}
}
