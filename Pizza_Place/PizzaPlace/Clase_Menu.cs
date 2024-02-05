namespace Pizza_Place.PizzaPlace
{
    public class Clase_Menu
    {
        public List<Clase_Pizza> Pizzas { get; set; } = new List<Clase_Pizza>();
        public void AgregarPizza(Clase_Pizza pizza) => Pizzas.Add(pizza);
        public Clase_Pizza? ObtenerPizza(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    }
}
