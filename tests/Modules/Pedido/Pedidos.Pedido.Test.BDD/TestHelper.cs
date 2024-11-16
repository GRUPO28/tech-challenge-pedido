using Pedidos.Pedido.Domain.Entities;
using Pedidos.Pedido.Domain.Enums;

namespace Pedidos.Pedido.Test.BDD;

public static class TestHelper
{
    public static string GerarIdValido()
    {
        return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 24);
    }
}
