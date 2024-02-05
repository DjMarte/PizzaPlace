﻿namespace Pizza_Place.PizzaPlace
{
    public class Estado
    {
        public Menu Menu { get;} = new Menu();
        public CanastaDeCompra CanastaDeCompra { get; } = new CanastaDeCompra();
        public InterfazDeUsuario InterfazDeUsuario { get; } = new InterfazDeUsuario();
    }
}
