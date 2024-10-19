using Pedidos.Pedido.Application.Abstractions;
using Pedidos.Common.Exceptions;
using Pedidos.Pedido.Domain.Abstractions;
using Entity = Pedidos.Pedido.Domain.Entities;

namespace Pedidos.Pedido.Application.UseCases.AtualizarPedido;

public class AtualizarPedidoUseCase : IUseCase<AtualizarPedidoRequest>
{
    private readonly IPedidoApplicationService _pedidoApplicationService;
    private readonly IPedidoRepository _pedidoRepository;

    public AtualizarPedidoUseCase(IPedidoApplicationService pedidoApplicationService, IPedidoRepository pedidoRepository)
    {
        _pedidoApplicationService = pedidoApplicationService;
        _pedidoRepository = pedidoRepository;
    }

    public async Task ExecuteAsync(AtualizarPedidoRequest request)
    {
        Entity.Pedido pedido = await _pedidoRepository.ObterPedidoAsync(request.IdPedido);

        if (pedido is null)
        {
            throw new ApplicationNotificationException("Pedido não encontrado");
        }

        if (request.Itens is not null)
        {
            var itensPedido = await _pedidoApplicationService.GerarItensPedidoAsync(request.Itens);

            pedido.AtualizarItens(itensPedido);
        }

        if (request.Status is not null)
        {
            pedido.AtualizarStatus(request.Status.Value);
        }

        await _pedidoRepository.AtualizarPedidoAsync(pedido);
    }
}
