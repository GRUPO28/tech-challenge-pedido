using Pedidos.Pedido.Domain.Enums;
using Pedidos.Pedido.Domain.Entities;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySqlDB.Models;

public class PedidoModel : BaseModel
{
    public PedidoModel(string v)
    {
        V = v;
    }

    public required string Codigo { get; set; }
    public int? IdCliente { get; set; }
    public StatusPedido? Status { get; set; }
    public required List<ItemPedidoModel> Itens { get; set; }
    public string V { get; }

    internal static Pedidos.Pedido.Domain.Entities.Pedido MapToDomain(PedidoModel model)
    {
        if (model == null) return null!;

        return new Pedidos.Pedido.Domain.Entities.Pedido(
            model.Id.ToString(),
            model.Codigo,
            model.IdCliente.ToString(),
            model.Status ?? StatusPedido.Recebido,
            model.DataCriacao,
            model.DataAtualizacao,
            ItemPedidoModel.MapToDomain(model.Itens)
        );
    }

    internal static PedidoModel MapFromDomain(Pedidos.Pedido.Domain.Entities.Pedido entity)
    {
        if (entity == null) return null!;

        return new PedidoModel(entity.Id.ToString())
        {
            Codigo = entity.Codigo,
            IdCliente = int.TryParse(entity.IdCliente, out var idCliente) ? idCliente : (int?)null,
            Status = entity.Status,
            DataCriacao = entity.DataCriacao,
            DataAtualizacao = entity.DataAtualizacao,
            Itens = ItemPedidoModel.MapFromDomain(entity.Itens).ToList()
        };
    }

    internal static IEnumerable<Pedidos.Pedido.Domain.Entities.Pedido> MapToDomain(IEnumerable<PedidoModel> models)
    {
        return models.Select(model => MapToDomain(model)).ToList();
    }

    internal static IEnumerable<PedidoModel> MapFromDomain(IEnumerable<Pedidos.Pedido.Domain.Entities.Pedido> entities)
    {
        return entities.Select(entity => MapFromDomain(entity)).ToList();
    }
}