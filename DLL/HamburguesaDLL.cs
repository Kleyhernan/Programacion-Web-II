using LibreriaDeClases;
using ProgramacionWebII_Actividad_Complementaria_CSharp;
using System.Collections.Generic;

namespace DLL
{
    public class HamburguesaDLL
    {
        private static readonly List<Hamburguesa> unaHamburguesa = new()
    {
        new Hamburguesa ( "Libra", 3000, 1),
        new Hamburguesa ("Grand Tasty",7600,2),
        new Hamburguesa ("Tasty",8000,3),
    };

        public List<Hamburguesa> TodasLasHamburguesas ()
        {
            return unaHamburguesa;
        }

        public Hamburguesa HamburguesasPorId(int id)
        {
            return unaHamburguesa.Find(h => h.IdHamburguesa == id);
        } 

        public void AgregarHamburguesas(Hamburguesa hamburguesa)
        {
            unaHamburguesa.Add(hamburguesa);
        } 


        public void ActualizarHamburguesas(Hamburguesa hamburguesa)
        {
            int index = unaHamburguesa.FindIndex(h => h.IdHamburguesa == hamburguesa.IdHamburguesa);
            if (index != -1) 
            {
              unaHamburguesa[index] = hamburguesa;  
            }
        }

        
        public bool EliminarHamburguesas(int id)
        {
            Hamburguesa hamburguesa = unaHamburguesa.Find(h => h.IdHamburguesa == id);
            if (hamburguesa == null)
            {
                unaHamburguesa.Remove(hamburguesa);
                return true;
            }

            return false;
        }

    }


}























