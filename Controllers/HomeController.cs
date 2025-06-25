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
        salaEscape.StartTime = DateTime.Now; // arranca el tiempo
        HttpContext.Session.SetString("SalaDeEscape", objeto.ObjetoATexto(salaEscape));
        ViewBag.respuestas = salaEscape.respuestasSala;
        ViewBag.tiempoRestante = salaEscape.TimeLeft().TotalSeconds; 
        return View("sala1");
        //creo objeto salaescape y lo guardo en session
    }
    public IActionResult jugarSala(string respuestas)
    {

        // traigo de session veo que sala esta
        SalaDeEscape sala = objeto.TextoAObjeto<SalaDeEscape>(HttpContext.Session.GetString("SalaDeEscape"));
        if (sala.IsTimeUp())
        {
            return View("TiempoTerminado"); //crear una view de tiempo terminado
        }
        ViewBag.sala = sala.salaActual;
        sala.JugarPorSala(ViewBag.sala, respuestas);
        ViewBag.sala++;
        ViewBag.tiempoRestante = sala.TimeLeft().TotalSeconds; 
        HttpContext.Session.SetString("SalaDeEscape", objeto.ObjetoATexto(sala));
        return View("sala" + ViewBag.sala);
    }
    public IActionResult TiempoTerminado()
    {
        return View();
    }

}
