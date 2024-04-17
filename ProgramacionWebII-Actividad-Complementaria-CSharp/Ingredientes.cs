using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionWebII_Actividad_Complementaria_CSharp
{
    public class Ingredientes
    {
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public Ingredientes(string nombre, int cantidad)
        {
            Nombre = nombre;

            Cantidad = cantidad;
        }
    }
}
