using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNew.Models;

namespace WebApplicationNew
{
	public class CitiesDataStore
	{
		private static CitiesDataStore _store;

		public List<City> Cities { get; }

		public CitiesDataStore()
		{
			Cities = new List<City>
			{
				new City(1, "Moscow" ),
				new City(2, "Chelyabinsk" ),
				new City(3, "New-York" )
			};
		}

		public static CitiesDataStore GetInstanse()
		{
			if (_store == null)
				_store = new CitiesDataStore();

			return _store;
		}
	}
}
