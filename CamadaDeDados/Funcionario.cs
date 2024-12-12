using System;
using System.ComponentModel.DataAnnotations;

namespace CamadaDeDados
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(50,ErrorMessage = "Nome não pode exceder 50 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Gênero é obrigatório")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Cidade é obrigatório")]
        public string Cidade { get; set; }
        [Range(0, 100000, ErrorMessage = "Salário deve estar entre 0 - 100.000")]
        public decimal Salario { get; set; }
        [DataType(DataType.Date, ErrorMessage = "O formato da data não é valido") ]
        public DateTime DataNascimento { get; set; }
    }
}
