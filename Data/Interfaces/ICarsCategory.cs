using Proba.Data.Models;

namespace Proba.Data.Interfaces
{
	/// <summary>
	/// интерфейс для функции перечисления категорий
	/// </summary>
	public interface ICarsCategory
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
