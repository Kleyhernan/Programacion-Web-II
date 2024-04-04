using ProgramacionWebII_Actividad_Complementaria_CSharp;
using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class UsuarioDLL 
    {
        private static readonly List<Usuario> unUsuario = new()
        {
            new Usuario (1,"Sofia","Eroles"),
            new Usuario(2,"Isabella", "Taliente"),
            new Usuario (3,"Jose","Fernandez"),

        };
        
        public List<Usuario>TodosLosUsuarios()
        {
            return unUsuario;
        }

        public Usuario UsuariosPorId(int id)
        {
            return unUsuario.Find(u=> u.IdUsuario == id);
        }

        public void AgregarUsuarios(Usuario usuario) 
        {
          unUsuario.Add(usuario);
        }

        public bool EliminarUsuarios(int id) 
        {
            Usuario usuario = unUsuario.Find(u => u.IdUsuario == id);
            if (usuario != null)
            {
                unUsuario.Remove(usuario);
                return true;
            }
            return false;


        }

    
    }

}
