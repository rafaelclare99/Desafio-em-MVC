using Microsoft.AspNetCore.Mvc;

namespace ProgramaMVC_6_ErroRenderizacaoView.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Detalhes()
        {
            // Bug: Não passa um modelo para a view, mas a view espera um modelo
            return View();
        }
    }
}

