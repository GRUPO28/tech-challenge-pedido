using Microsoft.EntityFrameworkCore;
using Pedidos.Pedido.Infrastructure.Repositories.MySQL.Models;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySQL.Contexts;

public class CheckoutDbContext(DbContextOptions<CheckoutDbContext> options) : DbContext(options)
{
    public DbSet<PagamentoModel> Pagamentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PagamentoModel>();
    }

    public static string GetConnectionString()
    {
        var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__CheckoutDB");
        return Environment.ExpandEnvironmentVariables(connectionString!);
    }
}