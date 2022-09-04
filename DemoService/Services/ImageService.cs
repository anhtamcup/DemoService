using DemoService.Data;
using DemoService.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoService.Services
{
	public class ImageService : IImageServices
	{
		private readonly Context _context;
		public ImageService(Context context)
		{
			_context = context;
		}

		public async Task<List<ImageModel>> GetAll() => await _context.ImageModel.ToListAsync();
		public async Task<ImageModel> GetById(int Id) => await _context.ImageModel.Where(item => item.Id == Id).FirstOrDefaultAsync();
		public async Task<ImageModel> Get(ImageModel model) => await _context.ImageModel.FindAsync(model);
	}
}
