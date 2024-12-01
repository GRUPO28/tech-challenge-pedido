using Microsoft.EntityFrameworkCore;
using Pedidos.Pedido.Domain.Abstractions;
using Pedidos.Pedido.Domain.Entities;
using Pedidos.Pedido.Infrastructure.Repositories.MySQL.Contexts;
using Pedidos.Pedido.Infrastructure.Repositories.MySQL.Models;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySQL.Persistence;

public class PagamentoRepository : IPagamentoRepository
{
    private readonly CheckoutDbContext _context;

    public PagamentoRepository(CheckoutDbContext context)
    {
        _context = context;
    }

    public async Task<Pagamento> ObterPagamentoAsync(string idPedido)
    {
        PagamentoModel? result = await _context.Pagamentos.FirstOrDefaultAsync(p => p.PedidoId == idPedido);

        return PagamentoModel.MapToDomain(result!);
    }

    public async Task SalvarPagamentoAsync(Pagamento pagamento)
    {
        PagamentoModel model = PagamentoModel.MapFromDomain(pagamento);

        await _context.Pagamentos.AddAsync(model);
        await _context.SaveChangesAsync();
    }
}
