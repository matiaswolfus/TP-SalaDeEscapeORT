using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_MusicStore.Models;

namespace TP03_MusicStore.Controllers;

    public class HomeController : Controller
    {

  
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Catalogo.CrearDiscos();
        ViewBag.Discos = Catalogo.discos;
        return View();
    }
     public IActionResult Mostrardiscos (int num) 
    {
        if (Catalogo.discos.ContainsKey(num))
        {
            ViewBag.Disco = Catalogo.discos[num];
            ViewBag.num = num;
            return View ("Mostrardiscos");
        }
       

        return View ("Index");
    }
    
    }
