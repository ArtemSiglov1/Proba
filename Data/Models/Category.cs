namespace Proba.Data.Models
{
    /// <summary>
    /// Класс описывающий категорию автомобиля
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Desc {  get; set; } 
        public List<Car> Cars { get; set; } 
        public Category() { }
        public Category(string categoryName, string desc)
        {
            CategoryName = categoryName;
            Desc = desc;
        }
        public Category(int id, string categoryName, string desc, List<Car> cars)
        {
            Id = id;
            CategoryName = categoryName;
            Desc = desc;
            Cars = cars;
        }
    }
}
