Funcionalidade: ItemPedido
	Como usuario
	Quero criar Itens de Pedidos

Cenario: CriarItem1
	Dado Que a quantidade é 0
	Quando Eu tentar criar um item de pedido
	Então Lança uma DomainNotificationException para o Item

Cenario: CriarItem2
	Dado Que a quantidade é -1
	Quando Eu tentar criar um item de pedido
	Então Lança uma DomainNotificationException para o Item

Cenario: CriarItem3
	Dado Que a quantidade é 1
	Quando Eu tentar criar um item de pedido
	Então Item é criado com sucesso