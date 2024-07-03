using Microsoft.AspNetCore.Mvc;
using Proba.Data.Interfaces;
using Proba.ViewModels;
using System.Diagnostics.CodeAnalysis;

namespace Proba.Controlers
{
    /// <summary>
    /// Класс являющийся контроллером для машин унаследован от класса контроллер 
    /// </summary>
    public class CarController:Controller
    {
        private readonly ICars cars;
        private readonly ICarsCategory carsCategory;
        public CarController(ICars cars, ICarsCategory carsCategory)
        {
            this.cars = cars;
            this.carsCategory = carsCategory;
        }
        public ViewResult Result()
        {
            ViewBag.Title = "Страница с Автомобилями";
			CarResultViewModel viewModel = new CarResultViewModel()
			{
				GetCars = cars.Cars,
				CurrentCategory = "Avto"
			};
			return View(viewModel);
        }
    }
}
