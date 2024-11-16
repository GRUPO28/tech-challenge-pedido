namespace Pedidos.Pedido.Test.BDD;

public static class TestHelper
{
    public static string GerarIdValido()
    {
        return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 24);
    }
}
