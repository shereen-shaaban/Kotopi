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
		public IActionResult EditBook(Guid id)
        {
            Book book = baseservice.Getbyid(id);
            if(book!=null)
                return View("EditBook");
            else 
                return View("error");

		}
        public IActionResult DeleteBook(Guid id)
        {
            Book book = baseservice.Getbyid(id);
            if (book != null)
                return View("DeleteBook");
            else
                return View("error");

		}
        public IActionResult AddBook(Book book)
        {
            Book book1 = book;
            baseservice.ADD(book1);
            return View("AddBook", book1);
        }
    }
}
