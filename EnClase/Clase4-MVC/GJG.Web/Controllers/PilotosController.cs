using GJG.Entidades;
using GJG.Logica;
using Microsoft.AspNetCore.Mvc;

namespace GJG.Web.Controllers;

public class PilotosController : Controller
{
    private readonly IPilotosServicio _pilotosServicio;

    public PilotosController(IPilotosServicio pilotosServicio)
    {
        _pilotosServicio = pilotosServicio;
    }

    public IActionResult Index()
    {
        var pilotos = _pilotosServicio.Listar();
        return View(pilotos);
    }

    [HttpGet]
    public IActionResult NuevoPiloto(int escuderiaId)
    {
        var piloto = new Piloto
        {
            EscuderiaId = escuderiaId
        };
        return View(piloto);
    }   

    [HttpPost]
    public IActionResult NuevoPiloto(int escuderiaId, Piloto piloto)
    {
        _pilotosServicio.Agregar(escuderiaId, piloto);
        return RedirectToAction("Index", "Escuderias");
    }

    [HttpGet]
    public IActionResult EditarPiloto(Piloto piloto)
    {
        if (piloto == null)
        {
            return NotFound();
        }
        _pilotosServicio.Actualizar(piloto);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult EliminarPiloto(Piloto piloto)
    {
        if (piloto == null)
        {
            return NotFound();
        }
        _pilotosServicio.Eliminar(piloto);
        return RedirectToAction("Index");
    }


}
