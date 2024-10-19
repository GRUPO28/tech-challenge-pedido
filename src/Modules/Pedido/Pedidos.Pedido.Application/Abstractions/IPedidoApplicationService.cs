using Pedidos.Pedido.Application.DTO;
using Pedidos.Pedido.Domain.Entities;

namespace Pedidos.Pedido.Application.Abstractions;

public interface IPedidoApplicationService
{
    Task<List<ItemPedido>> GerarItensPedidoAsync(List<ItemPedidoRequestDto> itemRequests);
}
