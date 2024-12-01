namespace Pedidos.Pedido.Domain.Abstractions;

public interface IPagamentoRepository
{
    Task<Pagamento> ObterPagamentoAsync(string idPedido);
    Task SalvarPagamentoAsync(Pagamento pagamento);
}
