using System.ComponentModel.DataAnnotations;

namespace Pizza_Place.PizzaPlace
{
    public class Cliente
    {

        public int Id { get; set; }
		[Required(ErrorMessage = "Por favor ingrese un nombre")]
		public string Nombre { get; set; } = default!;
		[Required(ErrorMessage = "Por favor ingrese una calle con su número de casa.")]
		public string Calle { get; set; } = default!;
        [Required(ErrorMessage = "Por favor ingrese una ciudad.")]
        public string Ciudad { get; set; } = default!;
    }
}
