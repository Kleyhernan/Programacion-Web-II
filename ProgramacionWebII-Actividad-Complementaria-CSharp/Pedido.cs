using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProgramacionWebII_Actividad_Complementaria_CSharp
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdUsuario  { get; set; }
        public int IdHamburguesa { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }




        public Pedido (int idPedido, int idUsuario, int idHamburguesa, DateTime fecha, int cantidad)
        { 
            IdPedido = idPedido;
            IdUsuario = idUsuario;
            IdHamburguesa = idHamburguesa;
            Fecha = fecha;
            Cantidad = cantidad;
        }


    }
}
