using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_SalaDeEscape.Models;

namespace TP_SalaDeEscape.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    

    [HttpPost]
    public IActionResult empezar()
    {
        SalaDeEscape salaEscape = new SalaDeEscape();
        salaEscape.StartTime = DateTime.Now; // // arranca el tiempo
        HttpContext.Session.SetString("SalaDeEscape", objeto.ObjetoATexto(salaEscape));
        ViewBag.respuestas = salaEscape.respuestasSala;
      ViewBag.tiempoRestante = (int)salaEscape.TimeLeft().TotalSeconds;
        return View("sala1");
        //creo objeto salaescape y lo guardo en session
    }


    public IActionResult jugarSala(string respuestas)
{
    SalaDeEscape sala = objeto.TextoAObjeto<SalaDeEscape>(HttpContext.Session.GetString("SalaDeEscape"));

    if (sala.IsTimeUp())
    {
        return View("TiempoTerminado");
    }

    ViewBag.sala = sala.salaActual;
    bool paso = sala.JugarPorSala(ViewBag.sala, respuestas);

    if (paso)
    {
        ViewBag.sala++;
    }

    ViewBag.tiempoRestante = (int)sala.TimeLeft().TotalSeconds;
    HttpContext.Session.SetString("SalaDeEscape", objeto.ObjetoATexto(sala));

    // Siempre volvemos a mostrar la sala actual (no la siguiente)
    return View("sala" + sala.salaActual);
}
}
