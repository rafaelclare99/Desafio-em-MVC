using Microsoft.AspNetCore.Mvc;

namespace ProgramaMVC_4_ErroViewBag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MensagemBoasVindas = "Bem-vindo ao nosso site!";
            return View();
        }
    }
}

