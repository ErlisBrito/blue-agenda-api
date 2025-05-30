using AutoMapper;
using blue_agenda_api.Application.ViewModels;
using blue_agenda_api.Domain.Models;

namespace blue_agenda_api.Application.AutoMappers
{
    /// <summary>
    /// Representa um perfil de mapeamento de domínio para ViewModel usando AutoMapper.
    /// Esta classe é responsável por definir as regras de mapeamento entre objetos do domínio (entidades, modelos de negócio)
    /// e objetos de ViewModel (modelos de exibição de dados para a camada de apresentação/API).
    /// </summary>
    /// <remarks>
    /// Ao herdar de <see cref="Profile"/> do AutoMapper, esta classe permite registrar
    /// configurações de mapeamento específicas no contêiner de mapeamento do AutoMapper.
    /// Os mapeamentos são definidos dentro do construtor da classe.
    /// </remarks>
    public class DomainToViewModelMappingProfile : Profile
    {
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="DomainToViewModelMappingProfile"/>.
        /// </summary>
        /// <remarks>
        /// Dentro deste construtor, você deve usar os métodos <c>CreateMap&lt;TSource, TDestination&gt;()</c>
        /// para configurar os mapeamentos entre suas classes de domínio e suas classes de ViewModel.
        /// Por exemplo:
        /// <code>
        /// CreateMap&lt;MinhaEntidadeDeDominio, MinhaViewModel&gt;();
        /// CreateMap&lt;OutraEntidade, OutraViewModel&gt;()
        ///     .ForMember(dest => dest.PropriedadeNaViewModel, opt => opt.MapFrom(src => src.PropriedadeNaEntidade));
        /// </code>
        /// O objetivo principal é transformar os dados do formato do domínio para um formato adequado para
        /// ser exposto através de uma API ou interface de usuário, muitas vezes simplificando ou agregando dados.
        /// </remarks>
        public DomainToViewModelMappingProfile() 
        {
            CreateMap<EntityBase, BaseViewModel>();
            CreateMap<DadosContato, DadosContatoViewModel>();
            CreateMap<PessoaContato, PessoaContatoViewModel>();

        }    
    }
}
