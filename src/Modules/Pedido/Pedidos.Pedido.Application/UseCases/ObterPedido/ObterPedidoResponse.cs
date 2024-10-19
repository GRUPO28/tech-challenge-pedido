using Pedidos.Pedido.Application.DTO;
using Pedidos.Pedido.Domain.Enums;
using System.Text.Json.Serialization;

namespace Pedidos.Pedido.Application.UseCases.ObterPedido;

public class ObterPedidoResponse
{
    public string Id { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public string? IdCliente { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public StatusPedido? Status { get; set; } = null;

    public DateTime DataCriacao { get; set; }
    public DateTime? DataAtualizacao { get; set; }
    public decimal Total { get; set; }
    public List<ItemPedidoResponseDto> Itens { get; set; } = new();
}
