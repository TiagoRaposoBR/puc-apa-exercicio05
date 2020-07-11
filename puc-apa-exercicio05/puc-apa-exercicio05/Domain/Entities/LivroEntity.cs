using System;
using System.Collections.Generic;
using System.Text;

namespace puc_apa_exercicio05.Domain.Entities
{
	public class LivroEntity : BaseEntity
	{
		public string Nome { get; set; }

		private string _isbn;
		public string Isbn
		{
			get
			{
				return _isbn;
			}
			set
			{
				if (value != null && value.Length == 11)
					_isbn = value;
				else
					throw new Exception("ISBN deve ter 11 caracteres");
			}
		}

		private decimal _preco;
		public decimal Preco
		{
			get
			{
				return _preco;
			}
			set
			{
				if (value > 0)
					_preco = value;
				else
					throw new Exception("Preco do livro deve ser positivo");
			}
		}

		private List<string> _listaAutores;
		public List<string> ListaAutores
		{
			get
			{
				return _listaAutores;
			}
			set
			{
				if (value != null && value.Count > 0)
					_listaAutores = value;
				else
					throw new Exception("Livro deve ter pelo menos um autor");
			}
		}

		public LivroEntity(string nome, string isbn, decimal preco, List<string> listaAutores)
		{
			Nome = nome;
			Isbn = isbn;
			Preco = preco;
			ListaAutores = listaAutores;
		}
	}
}
