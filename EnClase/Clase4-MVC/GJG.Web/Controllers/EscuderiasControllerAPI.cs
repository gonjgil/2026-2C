// API Controller for Escuderias
using GJG.Entidades;
using GJG.Logica;
using Microsoft.AspNetCore.Mvc;

namespace GJG.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EscuderiasControllerAPI : ControllerBase
{
    private readonly IEscuderiasServicio _escuderiasServicios;

    public EscuderiasControllerAPI(IEscuderiasServicio escuderiasServicios)
    {
        _escuderiasServicios = escuderiasServicios;
    }

    // GET: api/<EscuderiasController>
    // CREAR Escuderia (no lo uso)
    // [HttpPost()]
    // public void Post([FromBody] Escuderia escuderia)
    // {
    //     _escuderiasServicios.Agregar(escuderia);
    // }

    // PATCH api/<EscuderiasController>/Actualizar/5
    // ACTUALIZAR datos de Escuderia
    [HttpPatch("Actualizar/{id}")]
    public void Patch([FromRoute] int id, [FromBody] Escuderia escuderia)
    {
        escuderia.Id = id;
        _escuderiasServicios.Actualizar(escuderia);
    }

    // DELETE api/<EscuderiasController>/5
    // BORRAR Escuderia
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _escuderiasServicios.Eliminar(id);
    }

    // GET: api/<EscuderiasController>
    // LISTAR todas las Escuderias
    [HttpGet]
    public IEnumerable<Escuderia> Get()
    {
        var escuderias = _escuderiasServicios.Listar();
        return escuderias.ToArray();
    }
}
