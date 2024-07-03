using Proba.Data.Models;

namespace Proba.Data.Interfaces
{
    /// <summary>
    /// интерфейс для функции перечисления машин 
    /// </summary>
    public interface ICars
    {
        IEnumerable<Car> Cars { get;  }
        IEnumerable<Car> GetFavCars { get; set; }
        Car GetObjectCar(int carID);
    }
}
