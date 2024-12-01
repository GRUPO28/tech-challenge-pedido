namespace Pedidos.Pedido.Domain.Entities;

public class Pagamento : Entity
{
    public string PedidoId { get; }
    public string UrlPagamento { get; }

    public Pagamento(string? id,
                   DateTime dataCriacao,
                   DateTime? dataAtualizacao,
                   string pedidoId,
                   string urlPagamento) : base(id, dataCriacao)
    {
        PedidoId = pedidoId;
        UrlPagamento = urlPagamento;
        DataAtualizacao = dataAtualizacao.HasValue ? dataAtualizacao.Value : null;

        Validate();
    }

    protected override void Validate()
    {
        return;
    }
}
