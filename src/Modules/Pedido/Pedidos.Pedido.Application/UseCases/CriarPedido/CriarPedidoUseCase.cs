using Pedidos.Pedido.Application.Abstractions;
using Pedidos.Pedido.Domain.Abstractions;
using Entity = Pedidos.Pedido.Domain.Entities;

namespace Pedidos.Pedido.Application.UseCases.CriarPedido;

public class CriarPedidoUseCase : IUseCase<CriarPedidoRequest, CriarPedidoResponse>
{
    private readonly IPedidoApplicationService _pedidoApplicationService;
    private readonly IPedidoRepository _pedidoRepository;

    public CriarPedidoUseCase(IPedidoApplicationService pedidoApplicationService, IPedidoRepository pedidoRepository)
    {
        _pedidoApplicationService = pedidoApplicationService;
        _pedidoRepository = pedidoRepository;
    }

    public async Task<CriarPedidoResponse> ExecuteAsync(CriarPedidoRequest request)
    {
        // TODO: Validar existencia do cliente

        var itensPedido = await _pedidoApplicationService.GerarItensPedidoAsync(request.Itens);

        var pedido = new Entity.Pedido(string.Empty, string.Empty, request.IdCliente, null, DateTime.UtcNow, null, itensPedido);

        string idPedido = await _pedidoRepository.CriarPedidoAsync(pedido);

        return new CriarPedidoResponse()
        {
            Id = idPedido
        };
    }
}
