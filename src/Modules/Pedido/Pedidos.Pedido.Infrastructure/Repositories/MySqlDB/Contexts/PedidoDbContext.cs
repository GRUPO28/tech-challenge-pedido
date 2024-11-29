using Microsoft.EntityFrameworkCore;
using Pedidos.Pedido.Infrastructure.Repositories.MySqlDB.Models;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySqlDB.Contexts;

public class PedidoDbContext(DbContextOptions<PedidoDbContext> options) : DbContext(options)
{
    public DbSet<PedidoModel> Pedidos { get; set; }
    public DbSet<ItemPedidoModel> ItensPedido { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PedidoModel>()
                    .HasMany(p => p.Itens)
                    .WithOne()
                    .HasForeignKey(i => i.PedidoId);
    }

    public static string GetConnectionString()
    {
        var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__ControlePedidosDB");
        return Environment.ExpandEnvironmentVariables(connectionString!);
    }
}
