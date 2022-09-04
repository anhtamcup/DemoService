using DemoService.Models;
using DemoService.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ImageController : ControllerBase
	{
		private readonly IImageServices _imageService;
		public ImageController(IImageServices imageService)
		{
			_imageService = imageService;
		}

		[HttpGet]
		public IEnumerable<ImageModel> Get()
		{
			return _imageService.GetAll().Result.ToArray();
		}

		[HttpPost("GetModel")]
		public IEnumerable<ImageModel> GetByModel(ImageModel model)
		{
			return _imageService.GetAll().Result.ToArray();
		}
	}
}
