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

        [HttpGet]
        public IActionResult Create()
        {
            return View("CreateEntry");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza nuovaPizza)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateEntry",nuovaPizza);
            }

            //Modello è corretto perciò aggiungo la pizza
            PizzaData.GetPizzas().Add(nuovaPizza);

            return RedirectToAction("Index","Pizza");
        }
    }

     
}
