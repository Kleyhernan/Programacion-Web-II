using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionWebII_Actividad_Complementaria_CSharp
{
    public class Hamburguesa
    {
        //Propiedades y metodos
        public string Nombre { get; set; }

        public int Precio { get; set; }

        public Hamburguesa(string nombre , int precio)
        {
            Nombre = nombre;

            Precio = precio;    
        }

    }
}
