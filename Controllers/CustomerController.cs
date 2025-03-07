using Microsoft.AspNetCore.Mvc;

namespace UITraining.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
