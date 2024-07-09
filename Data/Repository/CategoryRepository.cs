using Proba.Data.Interfaces;
using Proba.Data.Models;

namespace Proba.Data.Repository
{
	public class CategoryRepository : ICarsCategory
	{
		private readonly AppDBContent content;
		public CategoryRepository(AppDBContent content)
		{
			this.content = content;

		}
		public IEnumerable<Category> GetCategories =>content.Categories;
	}
}
