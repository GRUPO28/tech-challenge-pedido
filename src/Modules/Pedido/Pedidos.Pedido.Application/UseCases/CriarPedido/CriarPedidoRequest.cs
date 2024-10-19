using Pedidos.Pedido.Application.DTO;

namespace Pedidos.Pedido.Application.UseCases.CriarPedido;

public class CriarPedidoRequest
{
    public string? IdCliente { get; set; }
    public List<ItemPedidoRequestDto> Itens { get; set; } = new();
}
