using Pedidos.Common.Exceptions;
using Pedidos.Pedido.Domain.Entities;
using Pedidos.Pedido.Domain.Enums;

namespace Pedidos.Pedido.Test.BDD.StepDefinitions;

[Binding]
public class PedidoStepDefinitions
{
    private Action _act { get; set; }
    private Entity.Pedido _pedido { get; set; }

    #region Setup Methods

    private static Entity.Pedido CriarPedidoPadrao()
    {
        string? id = null;
        string? codigo = null;
        string? idCliente = null;
        StatusPedido? status = null;
        DateTime dataCriacao = DateTime.UtcNow;
        DateTime? dataFinalizacao = null;
        var itens = new List<ItemPedido>() { CriarItemPedidoPadrao() };

        return new(id, codigo, idCliente, status, dataCriacao, dataFinalizacao, itens);
    }

    private static ItemPedido CriarItemPedidoPadrao()
    {
        string? id = TestHelper.GerarIdValido();
        DateTime dataCriacao = DateTime.UtcNow;
        string produtoId = TestHelper.GerarIdValido();
        string nome = TestHelper.GerarIdValido().Substring(0, 5);
        string tipoProduto = "Lanche";
        string tamanhoProduto = "M";
        decimal preco = (decimal)new Random().NextDouble() * (100 - 1) + 1;
        int quantidade = (int)new Random().NextInt64(1, 3);
        string observacao = TestHelper.GerarIdValido().Substring(0, 5);

        return new(id, dataCriacao, produtoId, nome, tipoProduto, tamanhoProduto, Math.Round(preco, 2), quantidade, observacao);
    }

    #endregion

    [Then(@"Lança uma DomainNotificationException")]
    public void ThenLancaUmaDomainNotificationException()
    {
        Assert.Throws<DomainNotificationException>(_act);
    }

    [Given("Pedido onde o Status é (.*)")]
    public void GivenPedidoOndeStatusIgualA(string? status)
    {
        StatusPedido? statusParsed = Enum.TryParse<StatusPedido>(status, out var outStatus) ? outStatus : null;
        _pedido = new Entity.Pedido(null, null, null, statusParsed, DateTime.UtcNow, null, [CriarItemPedidoPadrao()]);
    }

    [Then("Status é atualizado para (.*)")]
    public void ThenStatusEAtualizadoPara(string? status)
    {
        StatusPedido? statusParsed = Enum.TryParse<StatusPedido>(status, out var outStatus) ? outStatus : null;

        _act();
        Assert.Equal(statusParsed, _pedido.Status);
    }

    #region ConfirmarPedido

    [When(@"Confirmar o pedido")]
    public void WhenTentarConfirmarOPedido()
    {
        _act = () => _pedido.ConfirmarPedido();
    }

    #endregion

    #region IniciarPreparo

    [When("Iniciar Preparo")]
    public void WhenIniciarPreparo()
    {
        _act = () => _pedido.IniciarPreparo();
    }

    #endregion

    #region FinalizarPreparo

    [When("Finalizar Preparo")]
    public void WhenFinalizarPreparo()
    {
        _act = () => _pedido.FinalizarPreparo();
    }

    #endregion

    #region Finalizar Pedido

    [When("Finalizar Pedido")]
    public void WhenFinalizarPedido()
    {
        _act = () => _pedido.FinalizarPedido();
    }

    #endregion
}