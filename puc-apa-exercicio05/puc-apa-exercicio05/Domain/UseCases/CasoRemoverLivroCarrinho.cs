using puc_apa_exercicio05.Domain.Entities;
using puc_apa_exercicio05.Domain.Interfaces;
using System.Linq;

namespace puc_apa_exercicio05.Domain.UseCases
{
    public class CasoRemoverLivroCarrinho
    {
        private ICarrinhoRepository _carrinhoRepository;

        public CasoRemoverLivroCarrinho(ICarrinhoRepository carrinhoRepository)
        {
            _carrinhoRepository = carrinhoRepository;
        }

        public void RemoveLivroCarrinho(UsuarioEntity usuario, LivroEntity livro)
        {
            CarrinhoEntity carrinho = _carrinhoRepository.GetByUser(usuario.Id);

            if (carrinho != null)
            {
                if (carrinho.Livros.Any(i => i.Id == livro.Id))
                {
                    carrinho.RemoverLivro(livro.Id);
                }

                if (carrinho.Livros.Count > 0)
                    _carrinhoRepository.Update(carrinho);
                else
                    _carrinhoRepository.Delete(carrinho);
            }
            else
            {
                throw new System.Exception("Usuário não tem carrinho!");
            }
        }


	}
}
