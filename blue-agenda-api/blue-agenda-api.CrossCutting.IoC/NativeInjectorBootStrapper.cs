using blue_agenda_api.Application.Interfaces;
using blue_agenda_api.Application.Services;
using blue_agenda_api.Data.Repository;
using blue_agenda_api.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace blue_agenda_api.CrossCutting.IoC
{
    /// <summary>
    /// Classe estática responsável por configurar a injeção de dependência (IoC - Inversion of Control)
    /// para os serviços da aplicação e da infraestrutura de dados.
    /// </summary>
    /// <remarks>
    /// Esta classe atua como um "bootstrapper" (inicializador) para o contêiner de injeção de dependência,
    /// registrando as interfaces e suas implementações concretas para que possam ser resolvidas
    /// automaticamente pelo sistema de injeção de dependência do .NET Core.
    /// Isso promove um acoplamento fraco e facilita a testabilidade do código.
    /// </remarks>
    public static class NativeInjectorBootStrapper
    {
        /// <summary>
        /// Registra todos os serviços necessários no contêiner de injeção de dependência.
        /// Este método centraliza as chamadas para os métodos de registro de serviços
        /// das diferentes camadas da aplicação.
        /// </summary>
        /// <param name="services">A coleção de serviços onde os serviços serão registrados.</param>
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterServicesApplication(services);
            RegisterServicesInfraData(services);
        }
        /// <summary>
        /// Registra os serviços pertencentes à camada de aplicação no contêiner de injeção de dependência.
        /// </summary>
        /// <param name="services">A coleção de serviços onde os serviços serão registrados.</param>
        /// <remarks>
        /// Nesta seção, você registraria as implementações de interfaces de serviços de aplicação (AppServices),
        /// que orquestram a lógica de negócio e interagem com a camada de domínio e infraestrutura.
        /// Exemplo: `services.AddScoped<IContatoAppService, ContatoAppService>();`
        /// O ciclo de vida `AddScoped` significa que uma nova instância do serviço será criada
        /// para cada requisição HTTP em uma aplicação web.
        /// </remarks>
        private static void RegisterServicesApplication(IServiceCollection services)
        {
            services.AddScoped<IContatoAppService, ContatoAppService>();
        }

        /// <summary>
        /// Registra os serviços pertencentes à camada de infraestrutura de dados no contêiner de injeção de dependência.
        /// </summary>
        /// <param name="services">A coleção de serviços onde os serviços serão registrados.</param>
        /// <remarks>
        /// Nesta seção, você registraria as implementações de interfaces de repositórios,
        /// que lidam com a persistência de dados (acesso a banco de dados, etc.).
        /// Exemplo: `services.AddScoped<IContatoRepository, ContatoRepository>();`
        /// O ciclo de vida `AddScoped` é comumente usado para repositórios.
        /// </remarks>
        private static void RegisterServicesInfraData(IServiceCollection services)
        {
            services.AddScoped<IContatoRepository, ContatoRepository>();
        }

    }
}
