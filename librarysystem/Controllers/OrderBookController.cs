using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class OrderBookControler:Controller
    {

      
        //get actions
        public IActionResult Getall()
        {
            List<OrderBook> orderBooks = new List<OrderBook>();
            return View("Getall",orderBooks);
        }
        public IActionResult Details(Guid orderId)
        {
            OrderBook orderBook = new OrderBook();
            return View("Details", orderBook);
        }

        //post actions
        public IActionResult Delete(Guid orderId)
        {
            return View("Delete");
        }

        public IActionResult Edit(Guid orderId)
        {
            return View("Edit");
        }
    }
}
