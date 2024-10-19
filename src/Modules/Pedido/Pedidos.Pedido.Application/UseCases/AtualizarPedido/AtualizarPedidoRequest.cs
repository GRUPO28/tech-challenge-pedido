using Pedidos.Pedido.Application.DTO;
using Pedidos.Pedido.Domain.Enums;
using System.Text.Json.Serialization;

namespace Pedidos.Pedido.Application.UseCases.AtualizarPedido;

public class AtualizarPedidoRequest
{
    public string IdPedido { get; set; } = string.Empty;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public StatusPedido? Status { get; set; }

    public List<ItemPedidoRequestDto>? Itens { get; set; }
}
