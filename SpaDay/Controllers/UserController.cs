using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.Extensions.Logging;
using SpaDay.Models;
using System.Xml.Linq;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        //[HttpPost]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here

            if (verify == newUser.Password)
            {
                ViewBag.name = newUser.Username;
                return View("Index");
            }
            return Redirect("/user/add");
        }
    }
}
