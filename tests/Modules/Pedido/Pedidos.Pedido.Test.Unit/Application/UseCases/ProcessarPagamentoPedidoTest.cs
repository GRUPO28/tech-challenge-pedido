using Pedidos.Pedido.Application.UseCases.ProcessarPagamento;
using Pedidos.Pedido.Domain.Entities;
using Pedidos.Pedido.Domain.Enums;
using Pedidos.Common.Exceptions;
using Moq;
using Pedidos.Pedido.Domain.Abstractions;

namespace Pedidos.Pedido.Test.Unit.Application.UseCases;

public class ProcessarPagamentoPedidoUseCaseTest : BaseUnitTest
{
    private readonly ProcessarPagamentoPedidoUseCase _useCase;
    private readonly Mock<IPedidoRepository> _pedidoRepositoryMock;

    public ProcessarPagamentoPedidoUseCaseTest()
    {
        _pedidoRepositoryMock = new();
        _useCase = new(_pedidoRepositoryMock.Object);
    }

    #region Setup Methods

    private static Entity.Pedido CriarPedidoPadrao(StatusPagamento statusPagamento = StatusPagamento.Pendente)
    {
        string? id = "663ec4510724f79af50364f0";
        string? codigo = "ABC123";
        string? idCliente = "cliente-123";
        StatusPedido statusPedido = StatusPedido.Finalizado;
        DateTime dataCriacao = DateTime.UtcNow;
        DateTime? dataFinalizacao = null;
        var itens = new List<ItemPedido>() { CriarItemPedidoPadrao() };

        return new Entity.Pedido(id, codigo, idCliente, statusPedido, dataCriacao, dataFinalizacao, itens)
        {
        };
    }

    private static ItemPedido CriarItemPedidoPadrao()
    {
        string? id = GerarIdValido();
        DateTime dataCriacao = DateTime.UtcNow;
        string produtoId = GerarIdValido();
        string nome = "Produto Teste";
        string tipoProduto = "Lanche";
        string tamanhoProduto = "M";
        decimal preco = 50.0m;
        int quantidade = 2;
        string observacao = "Sem observações";

        return new ItemPedido(id, dataCriacao, produtoId, nome, tipoProduto, tamanhoProduto, preco, quantidade, observacao);
    }

    #endregion   

    [Fact]
    public async Task ProcessarPagamentoAsync_Should_LancarExcecao_When_PedidoNaoEncontrado()
    {
        // Arrange
        _pedidoRepositoryMock.Setup(x => x.ObterPedidoAsync(It.IsAny<string>())).ReturnsAsync((Entity.Pedido)null);

        var request = new ProcessarPagamentoPedidoRequest
        {
            IdPedido = "pedido-inexistente",
            Status = "approved"
        };

        // Act & Assert
        await Assert.ThrowsAsync<ApplicationNotificationException>(() => _useCase.ExecuteAsync(request));

        _pedidoRepositoryMock.Verify(x => x.ObterPedidoAsync(It.IsAny<string>()), Times.Once);
        _pedidoRepositoryMock.Verify(x => x.AtualizarPedidoAsync(It.IsAny<Entity.Pedido>()), Times.Never);
    }

    [Fact]
    public async Task ProcessarPagamentoAsync_Should_NaoAtualizarStatus_When_StatusNaoAprovado()
    {
        // Arrange
        var pedido = CriarPedidoPadrao();

        _pedidoRepositoryMock.Setup(x => x.ObterPedidoAsync(pedido.Id!)).ReturnsAsync(pedido);

        var request = new ProcessarPagamentoPedidoRequest
        {
            IdPedido = pedido.Id!,
            Status = "pending"
        };

        // Act
        var response = await _useCase.ExecuteAsync(request);

        // Assert
        _pedidoRepositoryMock.Verify(x => x.ObterPedidoAsync(pedido.Id!), Times.Once);
        _pedidoRepositoryMock.Verify(x => x.AtualizarPedidoAsync(It.IsAny<Entity.Pedido>()), Times.Never);
        Assert.NotNull(response);
        Assert.Equal(StatusPagamento.Pendente, response.Status);
    }
}
