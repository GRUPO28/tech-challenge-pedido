using Pedidos.Pedido.Domain.Abstractions;
using Pedidos.Pedido.Domain.Enums;
using Pedidos.Pedido.Infrastructure.Repositories.MySqlDB.Contexts;
using Pedidos.Pedido.Infrastructure.Repositories.MySqlDB.Models;
using Microsoft.EntityFrameworkCore;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySqlDB.Persistence;

public class PedidoRepository : IPedidoRepository
{
    private readonly PedidoDbContext _context;

    public PedidoRepository(PedidoDbContext context)
    {
        _context = context;
    }

    public async Task<Domain.Entities.Pedido> ObterPedidoAsync(string idPedido)
    {
        var result = await _context.Pedidos
                                   .Include(p => p.Itens)
                                   .FirstOrDefaultAsync(p => p.Id == idPedido);

        return PedidoModel.MapToDomain(result);
    }

    public async Task<IEnumerable<Domain.Entities.Pedido>> ObterTodosPedidosAsync()
    {
        var result = await _context.Pedidos
                                   .Where(p => p.Status != StatusPedido.Finalizado)
                                   .Include(p => p.Itens)
                                   .ToListAsync();

        return PedidoModel.MapToDomain(result);
    }

    public async Task<string> CriarPedidoAsync(Domain.Entities.Pedido pedido)
    {
        var model = PedidoModel.MapFromDomain(pedido);

        await _context.Pedidos.AddAsync(model);
        await _context.SaveChangesAsync();

        return model.Id.ToString();
    }

    public async Task AtualizarPedidoAsync(Domain.Entities.Pedido pedido)
    {
        var model = PedidoModel.MapFromDomain(pedido);

        _context.Pedidos.Update(model);
        await _context.SaveChangesAsync();
    }
}
