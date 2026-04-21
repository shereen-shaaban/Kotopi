using BL.services;
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class EmployeeController:Controller
    {

		private IBaseservice<Employee> baseservice;
        public EmployeeController( IBaseservice<Employee> _baseservice)
        {
			baseservice = _baseservice;
        }
        public IActionResult Getall()
		{
			List<Employee> employees =baseservice.Getall();
			return View("Getall",employees);
		}
		public IActionResult Details(Guid id)
		{
			Employee employee = baseservice.Getbyid(id);
			if (employee != null)
				return View("Details", employee);
			else
				return View("error");
		}
		

		public IActionResult Add()
		{
			return View("Add");
		}
		[HttpPost]
		public IActionResult Add(Employee employee)
		{
			baseservice.ADD(employee);
			return View("index");
		}

		public IActionResult Edit(Guid id)
		{
			Employee employee = baseservice.Getbyid(id);
			if (employee != null)
				return View("Edit", employee);
			else
				return View("error");

		}

		[HttpPost]
		public IActionResult Edit(Employee employee)
		{
			baseservice.Edit(employee);
				return View("index");

		}
		public IActionResult Delete(Guid id)
		{
			Employee employee = baseservice.Getbyid(id);
			if (employee != null)
				return View("Delete");
			else
				return View("error");
		}
		[HttpPost]
		public IActionResult Delete(Employee employee)
		{
			baseservice.Delete(employee);
				return View("index");
		}

	}
}
