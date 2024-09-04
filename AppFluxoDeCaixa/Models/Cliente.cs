using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppFluxoDeCaixa.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [MaxLength(100, ErrorMessage = "O limite do campo é de 100 digitos.")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter, no máximo, 3 caracteres.")]
        public string CienteNome { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O campo Endereço é obrigatório!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo UF é obrigatório!")]
        [MaxLength(2, ErrorMessage = "O limite do campo é de 2 caracteres.")]
        [MinLength(2, ErrorMessage = "O limite do campo é de 2 caracteres.")]
        public string UF { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório!")]
        [MaxLength(8, ErrorMessage = "O limite do campo é de 8 caracteres.")]
        [MinLength(8, ErrorMessage = "O campo CEP deve ter no mínimo 8 caracteres.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório!")]
        public string Bairro { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo E-mail é obrigatório!")]
        public string Email { get; set; }
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O campo Celular é obrigatório!")]
        [MaxLength(11, ErrorMessage = "O limite do campo é de 11 digitos numéricos.")]
        [MinLength(11, ErrorMessage = "O campo Celular deve ter no mínimo 8 digitos numéricos.")]
        public string Celular { get; set; }

        [Display(Name = "Tipo de Pessoa")]
        [Required(ErrorMessage = "O campo Tipo de Pessoa é obrigatório!")]
        public string TipoPessoa { get; set; }

        [Display(Name = "CPF/CNPJ")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string CpfCnpj { get; set; }

        [Display(Name = "Campo de Cadastro")]
        [Required(ErrorMessage = "O campo Data de Cadastro é obrigatório!")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Data de Nasc./Fundação")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public DateTime DataNascFundacao { get; set; }

        [Display(Name = "Ativo?")]
        public bool CadastroAtivo { get; set; }

        [Display(Name = "Observação")]
        [Required(ErrorMessage = "O campo Observação é obrigatório!")]
        public string Observacao { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "O campo Número é obrigatório!")]
        public string Numero { get; set; }
    }
}
