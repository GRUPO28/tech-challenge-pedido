using Pedidos.Common.Exceptions;
using Pedidos.Pedido.Domain.Entities;

namespace Pedidos.Pedido.Test.BDD.StepDefinitions;

[Binding]
public class ItemPedidoStepDefinitions
{
    private Func<ItemPedido> _act { get; set; }
    private ItemPedido _itemPedido { get; set; }
    private int _quantidadeItem { get; set; }

    [Given("Que a quantidade é {int}")]
    public void GivenQueAQuantidadeE(int p0)
    {
        _quantidadeItem = p0;
    }

    [When("Eu tentar criar um item de pedido")]
    public void WhenEuTentarCriarUmItemDePedido()
    {
        _act = () => new ItemPedido(null!, DateTime.UtcNow, TestHelper.GerarIdValido(), "NomeTeste", "Sobremesa", "M", 10, _quantidadeItem, string.Empty);
    }

    [Then("Lança uma DomainNotificationException para o Item")]
    public void ThenLancaUmaDomainNotificationExceptionParaOItem()
    {
        Assert.Throws<DomainNotificationException>(_act);
    }

    [Then("Item é criado com sucesso")]
    public void ThenItemECriadoComSucesso()
    {
        _itemPedido = _act();
        Assert.NotNull(_itemPedido);
    }
}
