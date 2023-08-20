using FullStackBank;
using FullStackBank_Api.Models;

namespace FullStackBank.Interfaces;

public interface IClientesServices
{
    void CriarConta(Cliente cliente);
    List<PessoaFisica> ExibirClientesPF();
    List<PessoaJuridica> ExibirClientesPJ();
    Cliente BuscarCliente(int id);
    Cliente AtualizarPessoaFisica(PessoaFisica pessoaFisica, int id);
    Cliente AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica, int id);
    void DeletarCliente(int id);
    void AdicionarTransacao(Transacao transacao, int idCliente);
    List<Transacao> ListarTransacao(int idCliente);
    void CriarConta(PessoaJuridica pessoaJuridica);
}