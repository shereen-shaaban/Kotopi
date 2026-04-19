using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class BookController : Controller
    {
        public IActionResult GetallBooks()
        {
           List<Book> books = new List<Book>();
            return View("GetallBooks", books);
        }
        public IActionResult Details(int id)
        {
            Book book = new Book();
            return View("Details",book);
        }
        //filter by type ,published date,price ,publisher
		//public IActionResult Filter(object type)//i nBusiness layr we will have only one function but in the body check how to work 
		//{
		//	List<Book> books = new List<Book>();
		//	return View("Filter", books);
		//}

		public IActionResult EditBook(Guid id)
        {
            return View("EditBook");
        }
        public IActionResult DeleteBook(Guid id)
        {
            return View("DeleteBook");
        }
        public IActionResult AddBook()
        {
            Book book = new Book();
            return View("AddBook", book);
        }



    }
}
