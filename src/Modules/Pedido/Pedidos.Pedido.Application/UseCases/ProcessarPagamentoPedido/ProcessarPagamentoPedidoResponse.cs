using Pedidos.Pedido.Domain.Enums;

namespace Pedidos.Pedido.Application.UseCases.ProcessarPagamento;

public class ProcessarPagamentoPedidoResponse
{
    public StatusPagamento Status { get; set; }
}
