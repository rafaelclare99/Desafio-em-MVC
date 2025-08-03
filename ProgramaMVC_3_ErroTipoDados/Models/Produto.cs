using System;

namespace ProgramaMVC_3_ErroTipoDados.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; } // Bug: Preço deveria ser um tipo numérico (decimal, double)
    }
}

