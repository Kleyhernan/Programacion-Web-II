using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionWebII_Actividad_Complementaria_CSharp
{
    internal class Pedidos
    {
        public string Cliente { get; set; }

        public int Cantidad { get; set; }

        public Pedidos(string cliente, int cantidad)
        {
            Cliente = cliente;

            Cantidad = cantidad;
        }
    }
}
