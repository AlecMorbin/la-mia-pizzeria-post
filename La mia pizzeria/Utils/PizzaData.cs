using La_mia_pizzeria.Models;

namespace La_mia_pizzeria.Utils
{
    public static class PizzaData
    {
        private static List<Pizza> pizzas = new List<Pizza>();

        public static List<Pizza> GetPizzas()
        {
           
            for (int i = 0; i < 6; i++)
            {
                Pizza pizza = new Pizza(i,"Pizza n-" +i, "Lorem Ipsum is simply dummy text of the printing and typesetting... ","/img/pizza-margherita.png");
                pizzas.Add(pizza);
            }


            return pizzas;
        }
    }
}
