using puc_apa_exercicio05.Domain.Entities;
using puc_apa_exercicio05.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace puc_apa_exercicio05.Domain.UseCases
{
	public class CasoGerarPedido
	{
		private ICarrinhoRepository _carrinhoRepository;
		private IPedidoRepository _pedidoRepository;

		public CasoGerarPedido(ICarrinhoRepository carrinhoRepository, IPedidoRepository pedidoRepository)
		{
			_carrinhoRepository = carrinhoRepository;
			_pedidoRepository = pedidoRepository;
		}

		public void GerarPedido(CarrinhoEntity carrinho)
		{
			var pedido = new PedidoEntity();
			pedido.IdUsuario = carrinho.IdUsuario;
			pedido.Livros = carrinho.Livros;

			_pedidoRepository.Add(pedido);
			_carrinhoRepository.Delete(carrinho);
		}
		
	}
}
