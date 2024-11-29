using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pedidos.Pedido.Domain.Abstractions;
using Pedidos.Pedido.Infrastructure.Repositories.MySqlDB.Contexts;
using Pedidos.Pedido.Infrastructure.Repositories.MySqlDB.Persistence;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySqlDB;

public static class MySqlDbRegistror
{
    public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PedidoDbContext>(options => options.UseMySql(configuration.GetConnectionString("ControlePedidosDB"), 
            ServerVersion.AutoDetect(configuration.GetConnectionString("ControlePedidosDB"))));

        services.AddScoped<IPedidoRepository, PedidoRepository>();
    }
}