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
                        Img="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.bmw.md%2Fro%2Fall-models%2Fm-series%2Fm5-sedan%2F2021%2Fprezentare-generala-a-automobilelor-bmw-seria-5-sedan-m.html&psig=AOvVaw2jVZBHfSg_YRbhJ4Y3lEeq&ust=1720084823307000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCMjZ-sHFiocDFQAAAAAdAAAAABAE",
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
