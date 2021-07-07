using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }

        public IActionResult Category(int id)
        {
            return View();
        }
    }
}
