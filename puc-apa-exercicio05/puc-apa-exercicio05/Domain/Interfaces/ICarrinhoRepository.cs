using puc_apa_exercicio05.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace puc_apa_exercicio05.Domain.Interfaces
{
	public interface ICarrinhoRepository
	{
		void Add(CarrinhoEntity carrinho);
		void Update(CarrinhoEntity carrinho);
		void Delete(CarrinhoEntity carrinho);
		CarrinhoEntity Get(int id);
		CarrinhoEntity GetByUser(int userId);
	}
}
