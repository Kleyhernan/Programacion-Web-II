using Microsoft.AspNetCore.Mvc;
using LibreriaDeClases;
using DLL;
using ProgramacionWebII_Actividad_Complementaria_CSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly PedidoDLL pedidoDLL;

        public PedidosController()
        {
            pedidoDLL = new PedidoDLL();
        }
        // GET: api/<PedidosController>
        [HttpGet]
        public List<Pedido> Get()
        {
            return pedidoDLL.TodosLosPedidos();
        }

        // GET api/<PedidosController>/5
        [HttpGet("{id}")]
        public ActionResult <Pedido> Get(int id)
        {
            var pedido = pedidoDLL.PedidoPorId(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        // POST api/<PedidosController>
        [HttpPost]
        public ActionResult <Pedido> Post([FromBody] Pedido pedido)
        {
            pedidoDLL.AgregarPedidos(pedido);
            return CreatedAtAction(nameof(Get), new { id = pedido.IdPedido }, pedido);
        }

        // PUT api/<PedidosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pedido pedido)
        {
            if (id != pedido.IdPedido)
            {
                BadRequest();
            }
            pedidoDLL.ActualizarCantidad(id, pedido.Cantidad);
        }

        // DELETE api/<PedidosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!pedidoDLL.EliminarPedidos(id))
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
