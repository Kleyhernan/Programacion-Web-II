using Microsoft.AspNetCore.Mvc;
using LibreriaDeClases;
using DLL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamburguesaController : ControllerBase
    {

        private readonly HamburguesaDLL hamburguesaDLL;

        public HamburguesaController()
        {
            hamburguesaDLL = new HamburguesaDLL();
        }
        // GET: api/<HamburguesaController>
        [HttpGet]
        public List<Hamburguesa> Get()
        {
            return hamburguesaDLL.TodasLasHamburguesas();   
        }

        // GET api/<HamburguesaController>/5
        [HttpGet("{id}")]
        public ActionResult<Hamburguesa> Get(int id)
        {
            var hamburguesa=hamburguesaDLL.HamburguesasPorId(id);
            if (hamburguesa == null) 
            {
                return NotFound();            
            }
            return Ok(hamburguesa);
        }

        // POST api/<HamburguesaController>
        [HttpPost]
        public ActionResult<Hamburguesa> Post([FromBody] Hamburguesa hamburguesa)
        {
            hamburguesaDLL.AgregarHamburguesas(hamburguesa);
            return CreatedAtAction(nameof(Get), new { id = hamburguesa.IdHamburguesa }, hamburguesa);
        }

        // PUT api/<HamburguesaController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Hamburguesa hamburguesa) 
        
        {
          if (id!= hamburguesa.IdHamburguesa) 
            {
                return BadRequest();
            }
            hamburguesaDLL.ActualizarHamburguesas(hamburguesa);
            return NoContent();
        }
       

        // DELETE api/<HamburguesaController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id) 
        {
            if(hamburguesaDLL.EliminarHamburguesas(id)) 
            {
                return NotFound();
            }
            return NoContent() ;    
        }
        
    }
}
