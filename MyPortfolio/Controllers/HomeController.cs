using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using MyPortfolio.Models.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService _services;

        public HomeController(ILogger<HomeController> logger, IService services)
        {
            _services = services;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Project()
        {
            var result = _services.GetAllProjects();
            if (result != null) 
            {
                return View(result);
            }

            return View();
        }

       /* [HttpPost]
        public IActionResult Contact(Contact contactView)
        {
            var result = _services.CreateContact(contactView);
            if (result)
            {
                return Redirect("Home/Index");
            }

            return View();
        }
*/
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
         
        public IActionResult NotFoundPage()
        {
            return View();
        }
    }  
}
