using BL.services;
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class OrderController:Controller
    {
        private IBaseservice<Order> baseservice;
        public OrderController(IBaseservice<Order> _basservice)
        {
            baseservice = _basservice;
        }
        public IActionResult Getall()
        {
            List<Order> orders =baseservice.Getall();
            return View("Getall",orders);
        }
        public IActionResult Details(Guid id)
        {
            Order order = baseservice.Getbyid(id);
            if (order != null)
                return View("Details");
            else
                return View("error");
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            Order order = baseservice.Getbyid(id);
            if (order != null)
                return View("Delete");
            else
                return View("error");
        }
        [HttpPost]
		public IActionResult Delete(Order order)
		{
            baseservice.Delete(order);
				return View("Delete");
		}
		public IActionResult Add()
        {
            return View("Add");
        }
        [HttpPost]
		public IActionResult Add(Order order)
		{
            baseservice.ADD(order);
			return View("index");
		}
		public IActionResult Edit(Guid id)
		{
            Order order = baseservice.Getbyid(id);
            if (order != null)
                return View("index");
            else
                return View("error");
		}
        [HttpPost]
		public IActionResult Edit(Order order)
        {
            baseservice.Edit(order);
            return View("index");
        }
    }
}
