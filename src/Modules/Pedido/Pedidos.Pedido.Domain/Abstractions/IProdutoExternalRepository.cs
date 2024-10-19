namespace Pedidos.Pedido.Domain.Abstractions;

public interface IProdutoExternalRepository
{
    Task<IEnumerable<Produto>> ObterTodosProdutosAsync(bool apenasAtivos);
}
