// API Controller for Escuderias
using GJG.Entidades;
using GJG.Logica;
using Microsoft.AspNetCore.Mvc;

namespace GJG.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EscuderiaController : ControllerBase
{
    private readonly IEscuderiasServicio _escuderiasServicios;

    public EscuderiaController(IEscuderiasServicio escuderiasServicios)
    {
        _escuderiasServicios = escuderiasServicios;
    }

    // GET: api/<EscuderiaController>
    [HttpGet]
    public IEnumerable<Escuderia> Get()
    {
        var escuderias = _escuderiasServicios.Listar();
        return escuderias.ToArray();
    }

    // GET api/<EscuderiaController>/5
    [HttpGet("{id}")]
    public Escuderia Get(int id)
    {
        var escuderia = _escuderiasServicios.ObtenerPorId(id);
        if (escuderia == null)
        {
            return null;
        }
        return escuderia;
    }

    // POST api/<EscuderiaController>
    [HttpPost]
    public void Post([FromBody] Escuderia escuderia)
    {
        _escuderiasServicios.Agregar(escuderia);
    }

    // PUT api/<EscuderiaController>
    [HttpPut("{id}")]
    public void Put([FromBody] Escuderia escuderia)
    {
        _escuderiasServicios.Actualizar(escuderia);
    }

    // DELETE api/<EscuderiaController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _escuderiasServicios.Eliminar(id);
    }
}
