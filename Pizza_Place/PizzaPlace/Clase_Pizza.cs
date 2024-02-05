namespace Pizza_Place.PizzaPlace
{
    public class Clase_Pizza
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Clase_Especias Especias { get; set; }

        public Clase_Pizza(int id, string nombre, decimal precio, Clase_Especias especias)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Especias = especias;
        }
    }
}
