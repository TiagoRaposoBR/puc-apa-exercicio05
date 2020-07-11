using puc_apa_exercicio05.Domain.Entities;
using puc_apa_exercicio05.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace puc_apa_exercicio05.Domain.UseCases
{
    public class CasoAdicionarLivroCarrinho
	{
        private ICarrinhoRepository _carrinhoRepository;

        public CasoAdicionarLivroCarrinho(ICarrinhoRepository carrinhoRepository)
        {
            _carrinhoRepository = carrinhoRepository;
        }

        public void Adicionar(UsuarioEntity usuario, LivroEntity livro)
        {
            CarrinhoEntity carrinho = _carrinhoRepository.GetByUser(usuario.Id);
            if (carrinho == null)
            {
                carrinho = new CarrinhoEntity(usuario, livro);
                _carrinhoRepository.Add(carrinho);
            }
            else
            {
                carrinho.AdicionarLivro(livro);
                _carrinhoRepository.Update(carrinho);
            }
        }
    }
}
