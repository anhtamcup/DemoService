using DemoService.Data;
using DemoService.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoService.Services
{
	public class ImageService
	{
		private List<ImageModel> _images;
		public ImageService()
		{
		}

		public async Task<List<ImageModel>> GetAll() => _images;
		public async Task<ImageModel> GetById(int Id) => _images.Where(item => item.Id == Id).FirstOrDefault();
		public async Task<ImageModel> Get(ImageModel model) => _images.Find(item => item == model);
	}
}
