using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaDeClases
    {
    public class Hamburguesa
    {
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public int IdHamburguesa { get; set; }


        
        
        
        public  Hamburguesa ( string nombre, double precio, int idHamburguesa )
        {
            Nombre = nombre;
            Precio = precio;
            IdHamburguesa = idHamburguesa;
        }




    }

}

