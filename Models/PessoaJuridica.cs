namespace FullStackBank_Api.Models
{


    public class PessoaJuridica : Cliente
    {

        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        //public List<string> Socios { get; set; } = new List<string>();
        public DateTime DataAbertura { get; set; }

        public PessoaJuridica(string email, string telefone, string endereco, int numeroConta, List<Transacao> extrato, string cnpj, string razaoSocial, string nomeFantasia, DateTime dataAbertura) : base(email, telefone, endereco, numeroConta, extrato)
        {
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            NumeroConta = numeroConta;
            Extrato = extrato;
            CNPJ = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            DataAbertura = dataAbertura;
        }

        public override string ResumoCliente()
        {

            string resumo = $"{NumeroConta}  |  {RazaoSocial}  |  {NomeFantasia}  |  {CNPJ}";

            return resumo;

        }

    }

}