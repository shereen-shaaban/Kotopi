using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class OrderController:Controller
    {
        public IActionResult Getall()
        {
            Order order =new Order();
            return View("Getall");
        }
        public IActionResult Details(Guid id)
        {
            Order order =new Order();
            return View("Details");
        }

        //filter status ,orderdate
        //public IActionResult Filter(object filter)
        //{
        //    List<Order>orders= new List<Order>();
        //    return View("Filter",filter);
        //}
        public IActionResult Delete(Guid id)
        {
            return View("Delete");
        }
        public IActionResult Add()
        {
            return View("Add");
        }
        public IActionResult Edit(Guid id)
        {
            return View("Edit");
        }
    }
}
