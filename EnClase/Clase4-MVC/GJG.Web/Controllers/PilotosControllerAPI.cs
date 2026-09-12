// API Controller for Pilotos
using GJG.Entidades;
using GJG.Logica;
using Microsoft.AspNetCore.Mvc;

namespace GJG.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PilotosControllerAPI : ControllerBase
{
    private readonly IPilotosServicio _pilotosServicios;

    public PilotosControllerAPI(IPilotosServicio pilotosServicios)
    {
        _pilotosServicios = pilotosServicios;
    }

    [HttpPatch("Actualizar/{id}")]
    public void Patch([FromRoute] int id, [FromBody] Piloto piloto)
    {
        piloto.Id = id;
        _pilotosServicios.Actualizar(piloto);
    }
}
