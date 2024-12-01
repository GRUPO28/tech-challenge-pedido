using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pedidos.Pedido.Infrastructure.Repositories.MySQL.Contexts;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySQL;
public static class MySqlDbRegistror
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddDbContext<CheckoutDbContext>(options => options.UseMySql(CheckoutDbContext.GetConnectionString(),
            ServerVersion.AutoDetect(CheckoutDbContext.GetConnectionString())));
    }
}