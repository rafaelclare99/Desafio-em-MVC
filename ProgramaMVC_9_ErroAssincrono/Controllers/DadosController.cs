using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ProgramaMVC_9_ErroAssincrono.Controllers
{
    public class DadosController : Controller
    {
        public async Task<IActionResult> ObterDados()
        {
            // Bug: Não usa await, o que pode causar um deadlock ou comportamento inesperado
            Task<string> dadosTask = SimularOperacaoAssincrona();
            string dados = dadosTask.Result; // Bloqueia a thread principal

            ViewBag.Dados = dados;
            return View();
        }

        private async Task<string> SimularOperacaoAssincrona()
        {
            await Task.Delay(2000); // Simula uma operação demorada
            return "Dados carregados com sucesso!";
        }
    }
}

