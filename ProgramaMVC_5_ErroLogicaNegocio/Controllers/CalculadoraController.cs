using Microsoft.AspNetCore.Mvc;

namespace ProgramaMVC_5_ErroLogicaNegocio.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Somar(int a, int b)
        {
            int resultado = a - b; // Bug: Lógica incorreta, deveria ser soma
            ViewBag.Resultado = resultado;
            return View();
        }
    }
}

