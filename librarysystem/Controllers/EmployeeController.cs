using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class EmployeeController:Controller
    {

		public IActionResult Getall()
		{
			List<Employee> employees = new List<Employee>();
			return View("Getall",employees);
		}
		public IActionResult Details(Guid id)
		{
			Employee employee = new Employee();
			return View("Details", employee);
		}
		//filter by salary,filter by age 
		//public IActionResult Filter(object filter)
		//{
		//	List<Employee> employees = new List<Employee>();
		//	return View("Filter", employees);
		//}
		public IActionResult Add()
		{
			return View();
		}

		public IActionResult Edit(Guid id)
		{
			return View("Edit");

		}
		public IActionResult Delete(Guid id)
		{
			return View("Delete");
		}

		
	}
}
