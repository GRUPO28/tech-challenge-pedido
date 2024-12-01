using MercadoPago.Client.Preference;
using Moq;
using Pedidos.Checkout.Application.UseCases.CheckoutPedido;
using Pedidos.Common.Exceptions;

namespace Pedidos.Checkout.Test.Unit.Application.UseCases
{
    [TestClass]
    public class CheckoutPedidoTest
    {
        private CheckoutPedidoUseCase _checkoutPedidoUseCase;

        [TestInitialize]
        public void Setup()
        {
            _checkoutPedidoUseCase = new CheckoutPedidoUseCase();
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationNotificationException))]
        public async Task ExecuteAsync_ShouldThrowException_WhenItensAreNull()
        {
            // Arrange
            var request = new CheckoutPedidoRequest
            {
                IdPedido = "123",
                Itens = null
            };

            // Act
            await _checkoutPedidoUseCase.ExecuteAsync(request);

            // Assert
            // Exception is expected, no Assert needed
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationNotificationException))]
        public async Task ExecuteAsync_ShouldThrowException_WhenPreferenceClientFails()
        {
            // Arrange
            var request = new CheckoutPedidoRequest
            {
                IdPedido = "123",
                Itens = new List<Item>() {             
                new Item()
                {
                    Id = "1",
                    Nome = "Produto 1",
                    Quantidade = 1,
                    Valor = 100
                }
            }
            };

            // Act
            await _checkoutPedidoUseCase.ExecuteAsync(request);

            // Assert
            // Exception is expected, no Assert needed
        }
    }
}

