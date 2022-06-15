using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int ID = 1)
        {
            // populate view data with params from url before rendering view
            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;

            return View();
        }
    }
}
