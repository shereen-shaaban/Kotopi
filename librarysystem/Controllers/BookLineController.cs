using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class BookLineController:Controller
    {

        public IActionResult Getall()
        {
            List<BookLine> booklines = new List<BookLine>();
            return View("Getall", booklines);
        }

        public IActionResult Details(Guid id)
        {
            BookLine bookline = new BookLine();
            return View("Details",bookline);
        }

        public IActionResult Add(BookLine bookLine)
        {
            return View("Add");
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
