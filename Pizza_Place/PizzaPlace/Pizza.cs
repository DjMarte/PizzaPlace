namespace Pizza_Place.PizzaPlace
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Especias Especias { get; set; }

        public Pizza(int id, string nombre, decimal precio, Especias especias)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Especias = especias;
        }
    }
}
