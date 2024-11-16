Funcionalidade: Pedido
	Como usuario
	Quero criar e atualizar pedidos

Cenario: ConfirmarPedido
	Dado Pedido onde o Status é Preparando
	Quando Confirmar o pedido
	Então Lança uma DomainNotificationException

Cenario: ConfirmarPedido2
	Dado Pedido onde o Status é nulo
	Quando Confirmar o pedido
	Então Status é atualizado para Recebido

Cenario: IniciarPreparo
	Dado Pedido onde o Status é Pronto
	Quando Iniciar Preparo
	Então Lança uma DomainNotificationException

Cenario: IniciarPreparo2
	Dado Pedido onde o Status é Recebido
	Quando Iniciar Preparo
	Então Status é atualizado para Preparando

Cenario: FinalizarPreparo
	Dado Pedido onde o Status é Recebido
	Quando Finalizar Preparo
	Então Lança uma DomainNotificationException

Cenario: FinalizarPreparo2
	Dado Pedido onde o Status é Preparando
	Quando Finalizar Preparo
	Então Status é atualizado para Pronto

Cenario: FinalizarPedido
	Dado Pedido onde o Status é Recebido
	Quando Finalizar Pedido
	Então Lança uma DomainNotificationException

Cenario: FinalizarPedido2
	Dado Pedido onde o Status é Pronto
	Quando Finalizar Pedido
	Então Status é atualizado para Finalizado
