using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Localization;

namespace LocTest.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IHtmlLocalizer _localizer;

        public HomeController(/*IHtmlLocalizer localizer*/)
        {
            //_localizer = localizer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            //ViewData["HelloString"] = _localizer["Hello"];

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
