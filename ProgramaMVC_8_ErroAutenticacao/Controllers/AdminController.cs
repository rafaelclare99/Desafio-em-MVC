using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ProgramaMVC_8_ErroAutenticacao.Controllers
{
    public class AdminController : Controller
    {
        [Authorize] // Bug: Não há configuração de autenticação, então isso não funcionará
        public IActionResult Index()
        {
            return View();
        }
    }
}

