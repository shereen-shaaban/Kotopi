using BL.services;
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class BookLineController:Controller
    {
        private IBaseservice<BookLine> baseservice;

        public BookLineController(IBaseservice<BookLine> _baseservice)
        {
            baseservice = _baseservice;
            
        }
        public IActionResult Getall()
        {
            List<BookLine> booklines = baseservice.Getall();
            return View("Getall", booklines);
        }

        public IActionResult Details(Guid id)
        {
            BookLine bookline =baseservice.Getbyid(id);
            if (bookline != null)
                return View("Details", bookline);
            else
                return View("error");
        }
        [HttpPost]
        public IActionResult Add(BookLine bookLine)
        {
            baseservice.ADD(bookLine);
            return View("index");
        }
        [HttpGet]
		public IActionResult Add()
		{
			return View("Add");
		}
		[HttpGet] //by default it's get  for all of them
        public IActionResult Edit(Guid id)
        {
            BookLine bookLine = baseservice.Getbyid(id);
            if (bookLine != null)
                return View("Edit");
            else
                return View("error");
        }
        [HttpPost]
        public IActionResult Edit(BookLine bookLine)
        {
            baseservice.Edit(bookLine);
            return View("index");//default untill decide where to go
		}
		public IActionResult Delete(Guid id)
		{

            BookLine bookline = baseservice.Getbyid(id);
            if (bookline != null)
                return View("Delete");
            else
                return View("error");
		}
        [HttpPost]
        public IActionResult Delete(BookLine bookLine)
        {
            baseservice.Delete(bookLine);
            return View("index");//default untill decide where to go

        }

	}
}
