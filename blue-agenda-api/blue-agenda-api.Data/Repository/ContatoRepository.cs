using blue_agenda_api.Data.Contexts;
using blue_agenda_api.Domain.Interfaces;
using blue_agenda_api.Domain.Models;
using Microsoft.Extensions.Logging;

namespace blue_agenda_api.Data.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AgendaContext _context;
        private readonly ILogger <ContatoRepository> _logger;

        public ContatoRepository(AgendaContext context, ILogger<ContatoRepository> logger)
        {
            _logger = logger;
            _context = context;
        }

        public async Task CriaContatoAsync(PessoaContato pessoaContato)
        {

        }

        public async Task<PessoaContato> ObterContatoAsync(Guid idContato)
        {
            return default;
        }

        public async Task<PessoaContato> EditarContatoAsync(PessoaContato pessoaContato)
        {
            return default;
        }

        public void DeletarContatoAsync(Guid idContato)
        {

        }

        public async Task<List<PessoaContato>> ListarContatosAsync()
        {
            return default;
        }

        public async Task<PessoaContato> ObterPessoaPorTelefone(string telefone)
        {
            return default;
        }

        public async Task<PessoaContato> ObterPessoaPorEmail(string email)
        {
            return default;
        }
    }
}
