using LibreriaDeClases;
using ProgramacionWebII_Actividad_Complementaria_CSharp;
using System.Collections.Generic;


namespace DLL
{
    public class PedidoDLL
    {
        private static readonly List<Pedido> unPedido = new()
        {
           new Pedido (1,1,1,DateTime.Now,1),
           new Pedido (2,2,2,DateTime.Now,3),
           new Pedido (3,3,3,DateTime.Now,4),

        };

        public List<Pedido> TodosLosPedidos()
        {
            return unPedido;
        }

        public List<Pedido> PedidoPorId(int id)
        {
            return unPedido.FindAll(p => p.IdPedido == id);
        } 


        public void AgregarPedidos(Pedido pedido)
        {
           unPedido.Add(pedido);
        }

        public void ActualizarCantidad(int id, int nuevaCantidad)
        {
            Pedido pedido = unPedido.Find(p => p.IdPedido==id);
            if (pedido == null)
            {
              pedido.Cantidad= nuevaCantidad;
            }
        } 



        public bool EliminarPedidos(int id)
        {
            Pedido pedido = unPedido.Find(p=>p.IdPedido==id);
            if (pedido != null) 
            {
              unPedido.Remove(pedido);
                return true;
            }

            return false;
        }

    }
}
