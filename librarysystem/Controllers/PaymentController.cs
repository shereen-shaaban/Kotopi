using System.ComponentModel.DataAnnotations;
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class PaymentController:Controller
    {
        public IActionResult Getall()
        {
           List< Payment> payments= new List<Payment>();
            return View("Getall", payments);
        }
        public IActionResult Details(Guid id)
        {
            Payment payment=new Payment();
            return View("Details", payment);
        }

        //filter payment date,customer id
        //public IActionResult Filter(object filter)
        //{
        //    List<Payment> payments= new List<Payment>();
        //    return View("Filter",payments);
        //}
        public IActionResult Edit(Guid id)
        {
           return View("Edit");
        }
        public IActionResult Delete(Guid id)
        {
            return View();
        }


    }
}
