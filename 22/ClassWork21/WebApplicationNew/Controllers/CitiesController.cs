using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationNew.Models;

namespace WebApplicationNew.Controllers
{
	[ApiController]
	[Route("cities")]
	public class CitiesController : ControllerBase
	{
		private CitiesDataStore _store;
		public CitiesController()
		{
			_store = CitiesDataStore.GetInstanse();
		}

		[HttpGet()]
		public JsonResult GetCities()
		{
			return new JsonResult(_store.Cities);
		}

		[HttpGet("{id}", Name = "GetCityById")]
		public IActionResult GetCity(int id)
		{
			var store = CitiesDataStore.GetInstanse();

			var city = store.Cities.FirstOrDefault(x => x.Id == id);

			if (city != null)
			{
				return Ok(city);
			}

			return NotFound("404 Not Found");
		}

		[HttpPost]
		public IActionResult AddCity([FromBody]City city)
		{
			if(_store.Cities.FirstOrDefault(
				x => x.Id == city.Id 
					|| x.Name == city.Name) != null)
			{
				return Conflict();
			}


			_store.Cities.Add(city);

			return CreatedAtRoute("GetCityById", new { id = city.Id }, city);
		}

		[Http]
		public IActionResult DeleteCity(int id)
		{
			var city = store.Cities.FirstOrDefault(x => x.Id == id);

			if(city == null)
			{
				return NotFound("404 Not Found");
			}
		}

		[Http]
		public IActionResult UpdateCity([FromBody] City city)
		{
			var city = store.Cities.FirstOrDefault(x => x.Id == city.id);

			if (city == null)
				return NotFound("404 Not Found");
		}

	}
}
