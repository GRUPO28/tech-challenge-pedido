using System.ComponentModel.DataAnnotations;
using Pedidos.Pedido.Domain.Entities;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySqlDB.Models;

public class ItemPedidoModel : BaseModel
{
    public string ProdutoId { get; set; }
    public string PedidoId { get; set; }
    public required string Nome { get; set; }
    public required string TipoProduto { get; set; }
    public required string Tamanho { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public string? Observacao { get; set; }
    public decimal Subtotal { get; set; }

    internal static ItemPedido MapToDomain(ItemPedidoModel model)
    {
        if (model == null) return null!;

        return new ItemPedido(
            model.Id.ToString(),
            model.DataCriacao,
            model.ProdutoId.ToString(),
            model.Nome,
            model.TipoProduto,
            model.Tamanho,
            model.Preco,
            model.Quantidade,
            model.Observacao
        );
    }

    internal static ItemPedidoModel MapFromDomain(ItemPedido entity)
    {
        if (entity == null) return null!;

        return new ItemPedidoModel
        {
            Id = entity.Id,
            ProdutoId = entity.ProdutoId,
            Nome = entity.Nome,
            TipoProduto = entity.TipoProduto,
            Tamanho = entity.Tamanho,
            Preco = entity.Preco,
            Quantidade = entity.Quantidade,
            Observacao = entity.Observacao,
            Subtotal = entity.Subtotal,
            DataCriacao = entity.DataCriacao
        };
    }

    internal static IEnumerable<ItemPedido> MapToDomain(IEnumerable<ItemPedidoModel> models)
    {
        return models.Select(model => MapToDomain(model)).ToList();
    }

    internal static IEnumerable<ItemPedidoModel> MapFromDomain(IEnumerable<ItemPedido> entities)
    {
        return entities.Select(entity => MapFromDomain(entity)).ToList();
    }

}

