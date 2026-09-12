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
        var escuderias = _pilotosServicio.Listar();
        return View(escuderias);
    }

    [HttpGet]
    public IActionResult NuevoPiloto()
    {
        return View();
    }

    [HttpPost]
    public IActionResult NuevoPiloto([FromRoute] int id, Piloto piloto)
    {
        _pilotosServicio.Agregar(id, piloto);
        return RedirectToAction("Index");
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
