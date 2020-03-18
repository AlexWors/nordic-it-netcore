using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassWork21.Controllers
{
	[ApiController]
	[Route("cities")]
	public class CitiesController : Controller
	{
		[HttpGet]
		public JsonResult GetCities()
		{
			var model = new List<object>
			{
				new{Id = 1, Name = "Moscow" },
				new{Id = 2, Name = "Chelyabinsk" },
				new{Id = 3, Name = "New-York" }
			};
			return new JsonResult(model); 
		}
	}
}
