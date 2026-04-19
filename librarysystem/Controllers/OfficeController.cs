using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class OfficeController:Controller
    {
        public IActionResult Getall()
        {
            List<Office> offices= new List<Office>();
            return View("Getall", offices);
        }
        public IActionResult Details(Guid id)
        {
            Office office= new Office();
            return View("Details", office);
        }

        public IActionResult Delete(Guid id)
        {
            return View("Delete");
        }
        public IActionResult Edit(Guid id)
        {
            return View("Edit");
        }
        public IActionResult Add(Office office)
        {
            return View("Add");
        }
    }
}
