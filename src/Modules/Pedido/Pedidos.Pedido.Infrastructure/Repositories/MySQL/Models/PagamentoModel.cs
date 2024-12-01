using Pedidos.Pedido.Domain.Entities;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySQL.Models;

public class PagamentoModel : BaseModel
{
    public string PedidoId { get; set; } = string.Empty;
    public string UrlPagamento { get; set; } = string.Empty;

    internal static Pagamento MapToDomain(PagamentoModel model)
    {
        if (model == null) return null!;

        return new Pagamento(
            model.Id.ToString(),
            model.DataCriacao,
            model.DataAtualizacao,
            model.PedidoId,
            model.UrlPagamento
        );
    }

    internal static PagamentoModel MapFromDomain(Pagamento entity)
    {
        if (entity == null) return null!;

        return new PagamentoModel
        {
            Id = entity.Id,
            DataCriacao = entity.DataCriacao,
            DataAtualizacao = entity.DataAtualizacao,
            PedidoId = entity.PedidoId,
            UrlPagamento = entity.UrlPagamento
        };
    }
}
