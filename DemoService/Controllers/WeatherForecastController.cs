using DemoService.Data;
using DemoService.Models;
using DemoService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

		private readonly ILogger<WeatherForecastController> _logger;
		private readonly Context _context;
		public WeatherForecastController(ILogger<WeatherForecastController> logger, Context context)
		{
			_logger = logger;
			_context = context;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			var result = _context.ImageModel.ToListAsync().Result;

			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}

		//[HttpGet(Name = "Image")]
		//public IEnumerable<Models.ImageModel> GetImage()
		//{
		//	var result = _imageService.GetAll().Result;
		//	return result;
		//}
	}
}