
using Microsoft.AspNetCore.Mvc;
using ProgramaMVC_1_ErroValidacao.Models;

namespace ProgramaMVC_1_ErroValidacao.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                // Simula o salvamento do cliente
                ViewBag.Mensagem = "Cliente cadastrado com sucesso!";
                return View("Sucesso", cliente);
            }
            return View(cliente);
        }
    }
}

