
using BL.services;
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class CustomerController:Controller
    {
        private IBaseservice<Customer> baseservice;
        public CustomerController(IBaseservice<Customer> _baseservice)
        {
            baseservice = _baseservice;
        }
        public IActionResult Getall()
        {
            List<Customer> customers = baseservice.Getall();
            return View("Getall",customers);
        }
		public IActionResult Details(Guid id)
		{
            Customer customer = baseservice.Getbyid(id);
            if (customer != null)
                return View("Details", customer);
            else
                return View("error");
		}
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            baseservice.ADD(customer);
            return View("index");
        }
        [HttpGet]
		public IActionResult Add()
		{
			return View("Add");
		}
		[HttpGet]
        public IActionResult Edit( Guid id)
        {
            Customer customer = baseservice.Getbyid(id);
            if (customer != null)
                return View("Edit",customer);
            else
                return View("error");
        }
        public  IActionResult Edit(Customer customer)
        {
            baseservice.Edit(customer);
            return View("index");
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            Customer customer = baseservice.Getbyid(id);
            if (customer != null)
                return View("Delete");
            else
                return View("error");
		}
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            baseservice.Delete(customer);
            return View("index");
        
        }


	}
}
