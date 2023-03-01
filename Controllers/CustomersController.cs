using Microsoft.AspNetCore.Mvc;
using shoppingAppMVC.Models;

namespace shoppingAppMVC.Controllers
{


    public class CustomersController : Controller
    {
        readonly Customers cObj = new Customers();

        public IActionResult ShowCustomers()
        {                                                                                                                                           
            return View(cObj.ShowCustomers());
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
