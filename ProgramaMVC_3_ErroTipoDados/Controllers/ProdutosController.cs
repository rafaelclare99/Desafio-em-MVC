
using Microsoft.AspNetCore.Mvc;
using ProgramaMVC_3_ErroTipoDados.Models;

namespace ProgramaMVC_3_ErroTipoDados.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Detalhes(Produto produto)
        {
            // Bug: Tentativa de realizar operações matemáticas com string 'Preco'
            // double precoNumerico = Convert.ToDouble(produto.Preco);
            // ViewBag.PrecoComDesconto = precoNumerico * 0.9;

            return View(produto);
        }
    }
}

