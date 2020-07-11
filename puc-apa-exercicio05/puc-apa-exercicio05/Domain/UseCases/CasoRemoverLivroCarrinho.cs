using puc_apa_exercicio05.Domain.Entities;
using System.Linq;

namespace puc_apa_exercicio05.Domain.UseCases
{
    public class CasoRemoverLivroCarrinho
	{
        public void RemoveLivroCarrinho(
            CarrinhoEntity carrinho, LivroEntity livro)
        {
            if(carrinho.Livros.Any(i => i.Id == livro.Id))
            {
                carrinho.RemoverLivro(livro.Id);
            }
        }


	}
}
