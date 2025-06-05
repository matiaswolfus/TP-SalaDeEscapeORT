using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRESENTACION_PERSONAL_GRUPO.Models;

namespace PRESENTACION_PERSONAL_GRUPO.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        grupo.inicializarGrupo();
        ViewBag.integrantes = grupo.integrantes;
        return View();
    }

    public IActionResult selectIntegrante (int DNI) 
    {
        if (grupo.integrantes.ContainsKey(DNI))
        {
            ViewBag.datosPersonales = grupo.integrantes[DNI].datosPersonales;
              ViewBag.DNI = DNI;
            return View("infoDatosPersonales");
        }
        return View ("Index");          
    }

    public IActionResult MostrarDatosFamiliares (int DNI) 
    {
        if (grupo.integrantes.ContainsKey(DNI))
        {
            ViewBag.datosFamiliares = grupo.integrantes[DNI].datosFamiliares;
            ViewBag.DNI = DNI;
            return View ("infoDatosFamiliares");
        }

        return View ("Index");
    }


    public IActionResult MostrarDatosInteres (int DNI)
    {
        if (grupo.integrantes.ContainsKey(DNI))
        {
            ViewBag.datosInteres = grupo.integrantes[DNI].datosIntereses;
            ViewBag.DNI = DNI;
            return View ("infoDatosInteres");
        }

        return View ("Index");
    }


}
