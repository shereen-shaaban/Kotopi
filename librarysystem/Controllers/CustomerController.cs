
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class CustomerController:Controller
    {
       public IActionResult Getall()
        {
            List<Customer> customers = new List<Customer>();
            return View("Getall",customers);
        }
		public IActionResult Details()
		{
			Customer customer= new Customer();
			return View("Details", customer);
		}
       
        public IActionResult Add(
            )
        {
            return View("Add");
        }

        public IActionResult Edit( Guid id)
        {
            return View("Edit");
        }
        public IActionResult Delete(Guid id)
        {
			return View("Delete");
		}


	}
}
