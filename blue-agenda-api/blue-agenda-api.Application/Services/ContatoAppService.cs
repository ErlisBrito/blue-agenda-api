using blue_agenda_api.Application.Interfaces;
using blue_agenda_api.Application.ViewModels;
using blue_agenda_api.Common;
using blue_agenda_api.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace blue_agenda_api.Application.Services
{
    public class ContatoAppService : IContatoAppService
    {
        private readonly ILogger<ContatoAppService> _logger;
        private readonly IContatoRepository _contatoRepository;

        public ContatoAppService(ILogger<ContatoAppService> logger, IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
            _logger = logger;
        }

        public async Task<Resultado<PessoaContatoViewModel>> CriaContatoAsync(PessoaContatoViewModel pessoaContato)
        {
            try
            {

            }
            catch (Exception ex)
            {
                return Resultado<PessoaContatoViewModel>.ErroMensagem($"Erro ao cadastrar o novo Contato {ex.Message}!");
            }
        }

        public async Task<Resultado<PessoaContatoViewModel>> ObterContatoAsync(Guid idContato)
        {
            return default;
        }

        public async Task<Resultado<PessoaContatoViewModel>> EditarContatoAsync(PessoaContatoViewModel pessoaContato)
        {
            return default;
        }

        public Task<Resultado<bool>> DeletarContatoAsync(Guid idContato)
        {
            return default;
        }

        public async Task<Resultado<List<PessoaContatoViewModel>>> ListarContatosAsync()
        {
            return default;
        }

        private async Task<bool> VerificarDuplicidadeContatoAsync()
        {
            try
            {
                //var resul = await 
                return default(bool);

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
