using Microsoft.AspNetCore.Mvc;
using LibreriaDeClases;
using DLL;
using ProgramacionWebII_Actividad_Complementaria_CSharp;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly UsuarioDLL usuarioDLL;

        public UsuarioController() 
        {
          usuarioDLL = new UsuarioDLL();
        }
           

        // GET: api/<UsuarioController>
        [HttpGet]
        public List<Usuario> Get()
        {
            return usuarioDLL.TodosLosUsuarios();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public ActionResult <Usuario> Get(int id)
        {
            var usuario = usuarioDLL.UsuariosPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public ActionResult <Usuario> Post([FromBody] Usuario usuario)
        {
            usuarioDLL.AgregarUsuarios(usuario);
            return CreatedAtAction(nameof(Get), new { id = usuario.IdUsuario }, usuario);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!usuarioDLL.EliminarUsuarios(id))
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
