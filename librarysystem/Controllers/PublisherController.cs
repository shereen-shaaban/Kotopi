using BL.services;
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class PublisherController:Controller
    {
        private IBaseservice<Publisher> baseservice;
        public PublisherController(IBaseservice<Publisher> _baseservice)
        {
            baseservice = _baseservice;
        }
        public IActionResult Getall()
        {
            List<Publisher> publishers =baseservice.Getall();
            return View("Getall",publishers);
        }
        public IActionResult Details(Guid id)
        {
            Publisher publisher = baseservice.Getbyid(id);
            return View("Details",publisher);
        }
        public IActionResult Add(Publisher publisher)
        {
            baseservice.ADD(publisher);
            return View("index");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            Publisher publisher = baseservice.Getbyid(id);
            if (publisher != null)
                return View("Edit", publisher);
            else
                return View("error");
        }
        [HttpPost]
        public IActionResult Edit(Publisher publisher)
        {
            baseservice.Edit(publisher);
            return View("index");
        }
        [HttpGet]
		public IActionResult Delete(Guid id)
		{
            Publisher publisher = baseservice.Getbyid(id);
            if (publisher != null)
                return View("Delete");
            else
                return View("error");
		}

        [HttpPost]
        public IActionResult Delete(Publisher publisher)
        {
            baseservice.Delete(publisher);
            return View("index");
        }
	}
}
