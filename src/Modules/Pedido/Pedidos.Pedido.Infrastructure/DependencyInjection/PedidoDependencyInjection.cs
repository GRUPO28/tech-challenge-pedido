using Pedidos.Pedido.Application.Abstractions;
using Pedidos.Pedido.Application.Services;
using Pedidos.Pedido.Application.UseCases.AtualizarPedido;
using Pedidos.Pedido.Application.UseCases.CriarPedido;
using Pedidos.Pedido.Application.UseCases.ObterPedido;
using Pedidos.Pedido.Application.UseCases.ObterTodosPedidos;
using Pedidos.Pedido.Application.UseCases.ProcessarPagamento;
using Pedidos.Pedido.Domain.Abstractions;
using Pedidos.Pedido.Infrastructure.Repositories.Http;
using Pedidos.Pedido.Infrastructure.Repositories.MongoDB;
using Pedidos.Pedido.Infrastructure.Repositories.MongoDB.Contexts;
using Pedidos.Pedido.Infrastructure.Repositories.MongoDB.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Pedidos.Pedido.Infrastructure.Configurations;

namespace Pedidos.Pedido.Infrastructure.DependencyInjection;

public static class PedidoDependencyInjection
{
    public static void AddPedido(this IServiceCollection services, IConfiguration configuration)
    {
        RegisterConfigurations(services, configuration);
        RegisterContexts(services);
        RegisterServices(services, configuration);
        RegisterUseCases(services);
    }

    private static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IPedidoRepository, PedidoRepository>();
        services.AddScoped<IProdutoExternalRepository, ProdutoExternalRepository>();
        services.AddScoped<IPedidoApplicationService, PedidoApplicationService>();

        services.AddHttpClient("ProdutosApi", (serviceProvider, client) =>
        {
            var repositoryConfiguration = serviceProvider.GetRequiredService<IOptions<RepositoryConfiguration>>().Value;
            client.BaseAddress = new Uri(repositoryConfiguration.ProdutoApiUri);
        });
    }

    private static void RegisterUseCases(this IServiceCollection services)
    {
        services.AddScoped<IUseCase<ObterPedidoRequest, ObterPedidoResponse>, ObterPedidoUseCase>();
        services.AddScoped<IUseCase<ObterTodosPedidosRequest, ObterTodosPedidosResponse>, ObterTodosPedidosUseCase>();
        services.AddScoped<IUseCase<CriarPedidoRequest, CriarPedidoResponse>, CriarPedidoUseCase>();
        services.AddScoped<IUseCase<AtualizarPedidoRequest>, AtualizarPedidoUseCase>();
        services.AddScoped<IUseCase<ProcessarPagamentoPedidoRequest, ProcessarPagamentoPedidoResponse>, ProcessarPagamentoPedidoUseCase>();
    }

    private static void RegisterContexts(this IServiceCollection services)
    {
        MongoDbRegistror.RegisterDocumentResolver();
        services.AddScoped<PedidoDbContext>();
    }

    private static void RegisterConfigurations(IServiceCollection services, IConfiguration configuration)
    {
        services.AddOptions<RepositoryConfiguration>()
                .Bind(configuration.GetSection(nameof(RepositoryConfiguration)))
                .ValidateOnStart();
    }
}
