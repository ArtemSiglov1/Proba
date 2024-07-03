using Proba.Data.Interfaces;
using Proba.Data.Models;

namespace Proba.Data.Mokcs
{
    /// <summary>
    /// класс для реализации интерфейса ICategory
    /// </summary>
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> GetCategories
        {
            get
            {
                return new List<Category>
                {
                    new("Electro cars","New transport"),
                    new("Classic car","DVS")
                };
            }
        }
    }
}
