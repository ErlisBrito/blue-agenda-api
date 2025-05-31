using AutoMapper;
using blue_agenda_api.Application.ViewModels;
using blue_agenda_api.Domain.Models;

namespace blue_agenda_api.Application.AutoMappers
{
    /// <summary>
    /// Representa um perfil de mapeamento de ViewModel para domínio usando AutoMapper.
    /// Esta classe é responsável por definir as regras de mapeamento entre objetos de ViewModel
    /// (modelos de dados recebidos da camada de apresentação/API) e objetos do domínio (entidades, modelos de negócio).
    /// </summary>
    /// <remarks>
    /// Ao herdar de <see cref="Profile"/> do AutoMapper, esta classe permite registrar
    /// configurações de mapeamento específicas no contêiner de mapeamento do AutoMapper.
    /// Os mapeamentos são definidos dentro do construtor da classe.
    /// </remarks>
    public class ViewModelToDomainMappingProfile : Profile
    {
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ViewModelToDomainMappingProfile"/>.
        /// </summary>
        /// <remarks>
        /// Dentro deste construtor, você deve usar os métodos <c>CreateMap&lt;TSource, TDestination&gt;()</c>
        /// para configurar os mapeamentos entre suas classes de ViewModel e suas classes de domínio.
        /// Por exemplo:
        /// <code>
        /// CreateMap&lt;MinhaViewModel, MinhaEntidadeDeDominio&gt;();
        /// CreateMap&lt;OutraViewModel, OutraEntidade&gt;()
        ///     .ForMember(dest => dest.PropriedadeNaEntidade, opt => opt.MapFrom(src => src.PropriedadeNaViewModel));
        /// </code>
        /// O objetivo principal é transformar os dados recebidos (geralmente de uma requisição HTTP)
        /// de volta para o formato de domínio, que pode ser então persistido em um banco de dados
        /// ou utilizado por outras camadas de negócio.
        /// </remarks>
        public ViewModelToDomainMappingProfile() 
        {
            CreateMap<BaseViewModel, EntityBase>();
            CreateMap<DadosContatoViewModel, DadosContato>();
            CreateMap<PessoaContatoViewModel, PessoaContato>();
        }
    }
}
