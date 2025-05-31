using blue_agenda_api.Application.ViewModels;
using blue_agenda_api.Common;

namespace blue_agenda_api.Application.Interfaces
{
    public interface IContatoAppService
    {
        Task<Resultado<PessoaContatoViewModel>> CriaContatoAsync(PessoaContatoViewModel pessoaContato);
        Task<Resultado<PessoaContatoViewModel>> ObterContatoAsync(Guid idContato);

        Task<Resultado<PessoaContatoViewModel>> EditarContatoAsync(PessoaContatoViewModel pessoaContato);
        Task<Resultado<bool>> DeletarContatoAsync(Guid idContato);
    }
}
