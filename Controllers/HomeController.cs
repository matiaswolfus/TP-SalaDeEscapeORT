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
    public IActionResult Perdiste()
    {
        return View(); 
    }
       public IActionResult Volver()
    {
        return View(); 
    }
    public IActionResult empezar()
    {
        SalaDeEscape salaEscape = new SalaDeEscape();
        salaEscape.StartTime = DateTime.Now; 
        HttpContext.Session.SetString("SalaDeEscape", objeto.ObjetoATexto(salaEscape));
        ViewBag.respuestas = salaEscape.respuestasSala;
        ViewBag.tiempoRestante = (int)salaEscape.TimeLeft().TotalSeconds;
        return View("sala1");
        //creo objeto salaescape y lo guardo en session
    }




    public IActionResult jugarSala(string respuestas)
{
    SalaDeEscape sala = objeto.TextoAObjeto<SalaDeEscape>(HttpContext.Session.GetString("SalaDeEscape"));
    // Si el castigo terminó, limpiar castigoHasta
if (sala.castigoHasta != null && DateTime.Now >= sala.castigoHasta)
{
    sala.castigoHasta = null;
}


    if (sala.IsTimeUp())
    {
        return View("perdiste");
    }
     if (sala.EnCastigo)
    {
        ViewBag.tiempoRestante = (int)(sala.castigoHasta.Value - DateTime.Now).TotalSeconds;
        HttpContext.Session.SetString("SalaDeEscape", objeto.ObjetoATexto(sala));
        return View("castigo");
    }
    


    ViewBag.sala = sala.salaActual;
bool paso = sala.JugarPorSala(ViewBag.sala, (respuestas ?? "").ToLower().Replace(" ", ""));


    if (paso)
    {
        sala.intentosFallidos = 0; 
        ViewBag.sala++;
    } else 
    {
        sala.intentosFallidos++;
    }


    if (sala.intentosFallidos > 2)
        {
            sala.castigoHasta = DateTime.Now.AddSeconds(10);
            sala.intentosFallidos = 0; 
            ViewBag.tiempoRestante = 10;


            HttpContext.Session.SetString("SalaDeEscape", objeto.ObjetoATexto(sala));
            return View("Castigo");
        }


    ViewBag.tiempoRestante = (int)sala.TimeLeft().TotalSeconds;
    HttpContext.Session.SetString("SalaDeEscape", objeto.ObjetoATexto(sala));


    // Siempre volvemos a mostrar la sala actual (no la siguiente)
    return View("sala" + sala.salaActual);
}
}


