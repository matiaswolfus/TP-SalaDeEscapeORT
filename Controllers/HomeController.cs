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

    public IActionResult empezar()
    {
        SalaDeEscape salaEscape = new SalaDeEscape();
        HttpContext.Session.SetString("juegoDelAhorcado", objeto.ObjetoATexto(salaEscape));
        ViewBag.respuestas = salaEscape.respuestasSala;
        return View("Index");
        //creo objeto salaescape y lo guardo en session
    }
    public IActionResult jugarSala(string respuestas)
    {
        
       // traigo de session veo que sala esta
        SalaDeEscape sala = objeto.TextoAObjeto<SalaDeEscape>(HttpContext.Session.GetString("salaDeEscape"));
        ViewBag.sala = sala.salaActual;
        sala.JugarPorSala(ViewBag.sala, respuestas);
        return View("sala" + sala);
    }
 

}
