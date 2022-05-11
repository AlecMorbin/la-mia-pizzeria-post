using Microsoft.AspNetCore.Mvc;
using La_mia_pizzeria.Models;
using La_mia_pizzeria.Utils;


namespace La_mia_pizzeria.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaData.GetPizzas();
            return View(pizzas);
        }
    }
}
