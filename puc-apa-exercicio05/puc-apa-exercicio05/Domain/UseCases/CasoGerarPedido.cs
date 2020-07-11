using puc_apa_exercicio05.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace puc_apa_exercicio05.Domain.UseCases
{
	public class CasoGerarPedido
	{
		public PedidoEntity GerarPedido(CarrinhoEntity carrinho)
		{
			var pedido = new PedidoEntity();
			pedido.IdUsuario = carrinho.IdUsuario;
			pedido.Livros = carrinho.Livros;			

			return pedido;
		}
		
	}
}
