using Microsoft.AspNetCore.Mvc;
using TrpoLabs.WebApp.Models;
using TrpoLabs.Core;

namespace TrpoLabs.WebApp.Controllers
{
    public class CalculateAreaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalculateAreaViewModel());
        }

        [HttpPost]
        public IActionResult Index(CalculateAreaViewModel model)
        {
            if (ModelState.IsValid)
            {
                Calculator calculator = new Calculator();
                model.Resultado = calculator.CalcularAreaCono(model.Radio, model.Altura);
            }

            return View(model);
        }
    }
}
