using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class PublisherController:Controller
    {
        public IActionResult Getall()
        {
            List<Publisher> publishers = new List<Publisher>();
            return View("Getall",publishers);
        }
        public IActionResult Details(Guid id)
        {
            Publisher publisher = new Publisher();
            return View("Details",publisher);
        }
        // filter by type,age
        //public IActionResult Filter(object filter)
        //{
        //    List<Publisher>publishers = new List<Publisher>();
        //    return View("Filter",publishers);
        //}
        public IActionResult Add(Publisher publisher)
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
