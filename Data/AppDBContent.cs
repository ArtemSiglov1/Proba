using Microsoft.EntityFrameworkCore;
using Proba.Data.Models;


namespace Proba.Data
{
	public class AppDBContent:DbContext
	{
		public AppDBContent(DbContextOptions<AppDBContent> options):base(options) { }
		public DbSet<Car> Cars { get; set; }
		public DbSet<Category> Categories { get; set; }

	}
}
