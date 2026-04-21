using BL.services;
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class BookController : Controller
    {
        private readonly IBaseservice<Book> baseservice;
        public BookController(IBaseservice<Book> _baseservice)
        {
            baseservice = _baseservice;
        }
        public IActionResult GetallBooks()
        {
           List<Book> books = baseservice.Getall();
            return View("GetallBooks", books);
        }
        //get by id
        public IActionResult Details(Guid id)
        {
            Book book = baseservice.Getbyid(id);
            if(book!=null)
                return View("Details",book);
            else
				return View("error");

		}

        [HttpGet]
		public IActionResult Edit(Guid id)
        {
            Book book = baseservice.Getbyid(id);
            if(book!=null)
                return View("Edit",book);
            else 
                return View("error");
		}
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            baseservice.Edit(book);
            return View("index");
        }
        public IActionResult Delete(Guid id)
        {
            Book book = baseservice.Getbyid(id);
            if (book != null)
                return View("Delete");
            else
                return View("error");
		}
        public IActionResult Delete(Book book)
        {
            baseservice.Delete(book);
            return View("index");
        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            baseservice.ADD(book);
            return View("index");
        }
        [HttpGet]
		public IActionResult Add()
		{
			return View("Add");
		}
	}
}
