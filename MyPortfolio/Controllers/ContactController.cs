using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.Models.Services;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly IService _services;

        public ContactController(IService services)
        {
            _services = services;

        }
        [HttpPost]
        public IActionResult Index(ContactViewModel contactView)
        {
            var result = _services.CreateContact(contactView);
            if (result != null)
            {
                return Redirect("Home/Index");

            }
            else if (result == null)
            {

                return RedirectToAction("NotFound", "Index");

            }
            
            return View();
        }

    } 
}
