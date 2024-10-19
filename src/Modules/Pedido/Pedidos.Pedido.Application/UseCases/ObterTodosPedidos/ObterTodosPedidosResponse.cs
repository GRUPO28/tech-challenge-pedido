using Pedidos.Pedido.Application.UseCases.ObterPedido;

namespace Pedidos.Pedido.Application.UseCases.ObterTodosPedidos;

public class ObterTodosPedidosResponse
{
    public List<ObterPedidoResponse> Pedidos { get; set; } = [];
}
