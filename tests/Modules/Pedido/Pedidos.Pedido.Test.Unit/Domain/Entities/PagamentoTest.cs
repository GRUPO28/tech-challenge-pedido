using Pedidos.Pedido.Domain.Entities;

namespace Pedidos.Pedido.Test.Unit.Domain.Entities;

public class PagamentoTest : BaseUnitTest
{
    [Fact]
    public void Validate_Should_Pass_When_PagamentoValido()
    {
        var pagamento = new Pagamento(null!, DateTime.UtcNow, DateTime.UtcNow.AddMinutes(1), GerarIdValido(), "https://mercadolivre.com/fake-url");
        Assert.NotNull(pagamento);
    }
}
