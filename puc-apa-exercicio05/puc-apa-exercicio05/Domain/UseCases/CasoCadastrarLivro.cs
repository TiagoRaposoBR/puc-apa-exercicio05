using puc_apa_exercicio05.Domain.Entities;
using puc_apa_exercicio05.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace puc_apa_exercicio05.Domain.UseCases
{
	public class CasoCadastrarLivro
	{
		private ILivroRepository _livroRepository;

		public CasoCadastrarLivro(ILivroRepository livroRepository)
		{
			_livroRepository = livroRepository;
		}

		public void Cadastrar(string nome, string isbn, decimal preco, params string[] autores)
		{
			List<string> listaAutores = new List<string>(autores);
			Cadastrar(nome, isbn, preco, listaAutores);
		}

		public void Cadastrar(string nome, string isbn, decimal preco, List<string> autores)
		{
			LivroEntity livro = new LivroEntity(nome, isbn, preco, autores);
			_livroRepository.Add(livro);
		}
	}
}
