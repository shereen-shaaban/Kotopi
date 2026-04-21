using BL.services;
using DAL.repositories;
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class OfficeController:Controller
    {
        private IBaseservice<Office> baseservice;
        public OfficeController(IBaseservice<Office> _baseservice)
        {
            baseservice = _baseservice;
        }
        public IActionResult Getall()
        {
            List<Office> offices= baseservice.Getall();
            return View("Getall", offices);
        }
        public IActionResult Details(Guid id)
        {
            Office office= baseservice.Getbyid(id);
            if (office != null)
                return View("Details", office);
            else
                return View("error");
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            Office office = baseservice.Getbyid(id);
            if (office != null)
                return View("Delete");
            else
                return View("error");
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
			Office office = baseservice.Getbyid(id);
			if (office != null)
				return View("Edit",office);
			else
				return View("error");
		}
        [HttpPost]
		public IActionResult Edit(Office office)
		{
            baseservice.Edit(office);
				return View("index");
			
		}
		public IActionResult Add()
        {
            return View("Add");
        }
		public IActionResult Add(Office office)
		{
            baseservice.ADD(office);
			return View("index");
		}
	}
}
