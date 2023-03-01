using Microsoft.AspNetCore.Mvc;
using shoppingAppMVC.Models;

namespace shoppingAppMVC.Controllers
{
    public class ProductsController : Controller
    {
        readonly Products pObj = new Products();

        public IActionResult ShowProducts()
        {
            return View(pObj.ShowProducts());
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
