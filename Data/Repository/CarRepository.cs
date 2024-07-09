using Microsoft.EntityFrameworkCore;
using Proba.Data.Interfaces;
using Proba.Data.Models;

namespace Proba.Data.Repository
{
	public class CarRepository : ICars
	{
		private readonly AppDBContent content;
		public CarRepository(AppDBContent content)
		{
			this.content = content;
			
		}

		public IEnumerable<Car> Cars => content.Cars.Include(c=>c.Category);

		public IEnumerable<Car> GetFavCars => content.Cars.Where(p => p.IsFavourite).Include(c => c.Category);

		public Car GetObjectCar(int carID)=> content.Cars.FirstOrDefault(p => p.Id == carID);
	}
}
