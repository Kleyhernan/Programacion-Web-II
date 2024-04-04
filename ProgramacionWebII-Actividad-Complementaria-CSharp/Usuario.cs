using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionWebII_Actividad_Complementaria_CSharp
{
    public class Usuario

    {
        public int IdUsuario { get; set; }
        public string Nombre {get; set;}

        public string Apellido { get; set; }


        public Usuario (int idUsuario, string nombre, string apellido)
        { IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}
