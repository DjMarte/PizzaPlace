namespace Pizza_Place.PizzaPlace
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public void AgregarPizza(Pizza pizza) => Pizzas.Add(pizza);
        public Pizza? ObtenerPizza(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    }
}
