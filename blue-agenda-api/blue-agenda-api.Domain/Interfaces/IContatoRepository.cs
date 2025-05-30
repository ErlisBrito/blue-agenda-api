using blue_agenda_api.Domain.Models;

namespace blue_agenda_api.Domain.Interfaces
{
    public interface IContatoRepository
    {
        Task CriaContatoAsync(PessoaContato pessoaContato);
        Task<PessoaContato> ObterContatoAsync(Guid idContato);
        Task<PessoaContato> EditarContatoAsync(PessoaContato pessoaContato);
        void DeletarContatoAsync(Guid idContato);
        Task<List<PessoaContato>> ListarContatosAsync();
        Task<PessoaContato> ObterPessoaPorTelefone(string telefone);
        Task<PessoaContato> ObterPessoaPorEmail(string email);
    }
}
