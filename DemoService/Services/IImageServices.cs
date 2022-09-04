using DemoService.Models;

namespace DemoService.Services
{
	public interface IImageServices
	{
		Task<List<ImageModel>> GetAll();
		Task<ImageModel> GetById(int Id);
		Task<ImageModel> Get(ImageModel model);
	}
}
