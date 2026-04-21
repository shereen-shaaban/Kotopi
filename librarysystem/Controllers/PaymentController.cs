using System.ComponentModel.DataAnnotations;
using librarysystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace librarysystem.Controllers
{
    public class PaymentController:Controller
    {
		//not decided it's logic untill now  sigleton or not
		// note =>we wouldn't implement update action
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
        public IActionResult Delete(Guid id)
        {
            return View();
        }


    }
}
