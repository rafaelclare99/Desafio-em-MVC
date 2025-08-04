using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProgramaMVC_7_ErroInjecaoDependencia.Models;

namespace ProgramaMVC_7_ErroInjecaoDependencia.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

using Microsoft.AspNetCore.Mvc;
using ProgramaMVC_7_ErroInjecaoDependencia.Services;

namespace ProgramaMVC_7_ErroInjecaoDependencia.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMeuServico _meuServico;

        // Bug: Construtor não está injetando a dependência corretamente
        public HomeController()
        {
            // _meuServico = new MeuServico(); // Deveria ser injetado
        }

        public IActionResult Index()
        {
            ViewBag.Mensagem = _meuServico.GetMensagem(); // NullReferenceException aqui
            return View();
        }
    }
}

