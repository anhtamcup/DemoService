using DemoService.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoService.Data
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> option)
			: base(option) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<ImageModel>(
					eb =>
					{
						eb.HasNoKey();
						eb.ToTable("Image");
					});
		}

		public DbSet<ImageModel> ImageModel { get; set; } = default!;
	}
}
