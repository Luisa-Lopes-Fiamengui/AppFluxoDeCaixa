namespace AppFluxoDeCaixa.Models
{
    public class Fornecedor
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
