using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using MyPortfolio.Models;
using MyPortfolio.Models.Services;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IService _services;

        public ContactController(ILogger<ContactController> logger, IService services)
        {
            _services = services;
            _logger = logger;
        }

        public IActionResult Index(Contact contactView)
        {
            var result = _services.CreateContact(contactView);
            return View();
        }
    }
}
