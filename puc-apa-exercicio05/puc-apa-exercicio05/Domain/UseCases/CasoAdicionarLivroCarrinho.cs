using puc_apa_exercicio05.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace puc_apa_exercicio05.Domain.UseCases
{
	public class CasoAdicionarLivroCarrinho
	{
        public CasoAdicionarLivroCarrinho(CarrinhoEntity carrinho, LivroEntity livro)
        {
            carrinho.AdicionarLivro(livro);
        }
    }
}
