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

    public IActionResult emprezar()
    {
        SalaDeEscape.inicializarGrupo();
        return View(Index);
    }
    public IactionResult comparar()
    {
        


    }

}
