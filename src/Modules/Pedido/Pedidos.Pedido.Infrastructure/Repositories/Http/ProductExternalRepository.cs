using Pedidos.Pedido.Domain.Abstractions;
using Pedidos.Pedido.Infrastructure.Repositories.Http.DTO;
using Pedidos.Pedido.Domain.Entities;
using System.Text.Json;

namespace Pedidos.Pedido.Infrastructure.Repositories.Http;

public class ProdutoExternalRepository : IProdutoExternalRepository
{
    private readonly IHttpClientFactory _httpClientFactory;

    private static JsonSerializerOptions DefaultSerializerOptions = new() { PropertyNameCaseInsensitive = true };

    public ProdutoExternalRepository(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IEnumerable<Produto>> ObterTodosProdutosAsync(bool apenasAtivos)
    {
        HttpClient client = _httpClientFactory.CreateClient("ProdutosApi");

        string uri = $"{client.BaseAddress}?Ativo={apenasAtivos}&RetornarTodos=false";

        HttpResponseMessage response = await client.GetAsync(uri);
        
        response.EnsureSuccessStatusCode();

        string body = await response.Content.ReadAsStringAsync();

        var models = JsonSerializer.Deserialize<List<ProdutoApiDto>>(body, DefaultSerializerOptions);

        return ProdutoApiDto.MapToDomain(models!);
    }
}
