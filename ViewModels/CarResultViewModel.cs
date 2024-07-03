using Proba.Data.Models;
using System.Text.Json.Nodes;

namespace Proba.ViewModels
{
	/// <summary>
	/// класс для представления машин и текущей категории 
	/// </summary>
	public class CarResultViewModel
	{
		public IEnumerable<Car> GetCars { get; set; }
		public string CurrentCategory { get; set; } 
	}
}
