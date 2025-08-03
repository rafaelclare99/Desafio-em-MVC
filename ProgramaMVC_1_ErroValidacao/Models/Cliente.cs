using System;
using System.ComponentModel.DataAnnotations;

namespace ProgramaMVC_1_ErroValidacao.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(5, ErrorMessage = "O nome deve ter no máximo 5 caracteres.")] // Bug: Tamanho muito pequeno
        public string Nome { get; set; }

        [Range(18, 60, ErrorMessage = "A idade deve estar entre 18 e 60 anos.")]
        public int Idade { get; set; }
    }
}

