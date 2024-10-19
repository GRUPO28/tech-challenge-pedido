using Pedidos.Pedido.Application.Abstractions;
using Pedidos.Pedido.Application.UseCases.ObterPedido;
using Pedidos.Pedido.Domain.Abstractions;
using Mapster;
using Entity = Pedidos.Pedido.Domain.Entities;

namespace Pedidos.Pedido.Application.UseCases.ObterTodosPedidos;

public class ObterTodosPedidosUseCase : IUseCase<ObterTodosPedidosRequest, ObterTodosPedidosResponse>
{
    private readonly IPedidoRepository _pedidoRepository;

    public ObterTodosPedidosUseCase(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }

    public async Task<ObterTodosPedidosResponse> ExecuteAsync(ObterTodosPedidosRequest request)
    {
        IEnumerable<Entity.Pedido> pedidos = await _pedidoRepository.ObterTodosPedidosAsync();

        var response = new ObterTodosPedidosResponse();
        response.Pedidos = pedidos.Adapt<List<ObterPedidoResponse>>();

        return response;
    }
}
