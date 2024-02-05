namespace Pizza_Place.PizzaPlace
{
    public class CanastaDeCompra
    {
        public Cliente cliente { get; set; } = new Cliente();
        public List<int> Pedidos { get; set; } = new List<int>();
        public bool HaPagado { get; set; }

		public void Agregar(int pizzaId) => Pedidos.Add(pizzaId);
		public void RemoverEn(int pos) => Pedidos.RemoveAt(pos);
	}
}
