using Proba.Data.Interfaces;
using Proba.Data.Models;

namespace Proba.Data.Mokcs
{
    /// <summary>
    /// класс для реализации интерфейса ICars
    /// </summary>
    public class MockCars : ICars
    {
        private readonly ICarsCategory carsCategory = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car{Name="Bmw м5 f90",
                        ShortDesc="быстрый",
                        LongDesc="удоюный",
                        Img="/Img/BMWF90.jpg",
                        Price=5000,
                        IsFavourite= true,
                        Available= true,
                        Category= carsCategory.GetCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
