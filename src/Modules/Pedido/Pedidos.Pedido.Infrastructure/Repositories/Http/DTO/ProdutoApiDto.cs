namespace Pedidos.Pedido.Infrastructure.Repositories.Http.DTO;

public class TamanhoPrecoApiDto
{
    public string Key { get; set; }
    public decimal Value { get; set; }
}

public class ProdutoApiDto
{
    public string Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public string Nome { get; set; }
    public List<TamanhoPrecoApiDto> TamanhoPreco { get; set; }
    public string TipoProduto { get; set; }
    public string Descricao { get; set; }
    public bool Ativo { get; set; }

    internal static Domain.Entities.Produto MapToDomain(ProdutoApiDto model)
    {
        if (model is null) return null!;

        return new Domain.Entities.Produto(model.Id,
                                           model.Nome,
                                           model.TamanhoPreco.ToDictionary(x => x.Key, x => x.Value),
                                           model.TipoProduto,
                                           model.Descricao,
                                           model.DataCriacao,
                                           model.Ativo);
    }

    internal static IEnumerable<Domain.Entities.Produto> MapToDomain(IEnumerable<ProdutoApiDto> models)
    {
        var mapList = new List<Domain.Entities.Produto>();

        if (models is null || !models.Any()) return Enumerable.Empty<Domain.Entities.Produto>();

        foreach (var model in models)
        {
            try
            {
                mapList.Add(MapToDomain(model));
            }
            catch { }
        }

        return mapList;
    }
}
