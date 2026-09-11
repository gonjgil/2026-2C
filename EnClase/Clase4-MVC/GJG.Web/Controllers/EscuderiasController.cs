// MVC Controller for Escuderias
using GJG.Entidades;
using GJG.Logica;
using Microsoft.AspNetCore.Mvc;

namespace GJG.Web.Controllers;

public class EscuderiasController : Controller
{
    private readonly IEscuderiasServicio _escuderiasServicios;

    public EscuderiasController(IEscuderiasServicio escuderiasServicios)
    {
        _escuderiasServicios = escuderiasServicios;
    }

    public IActionResult Index()
    {
        var escuderias = _escuderiasServicios.Listar();

        return View(escuderias);
    }

    [HttpGet]
    public IActionResult Agregar()
    {
        return View(new Escuderia());
    }

    [HttpPost]
    public IActionResult Agregar(Escuderia escuderia)
    {
        _escuderiasServicios.Agregar(escuderia);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Actualizar(int id)
    {
        var encontrada = _escuderiasServicios.ObtenerPorId(id);
        if (encontrada == null)
        {
            return NotFound();
        }
        return View(encontrada);
    }

    [HttpPost]
    public IActionResult Actualizar(Escuderia escuderia)
    {
        var encontrada = _escuderiasServicios.ObtenerPorId(escuderia.Id);
        if (encontrada == null)
        {
            return NotFound();
        }
        _escuderiasServicios.Actualizar(escuderia);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Eliminar(int id)
    {
        var encontrada = _escuderiasServicios.ObtenerPorId(id);
        if (encontrada == null)
        {
            return NotFound();
        }
        _escuderiasServicios.Eliminar(id);
        return RedirectToAction("Index");
    }
}
