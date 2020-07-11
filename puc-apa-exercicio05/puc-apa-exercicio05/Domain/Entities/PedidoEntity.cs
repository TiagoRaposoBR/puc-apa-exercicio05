using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace puc_apa_exercicio05.Domain.Entities
{
    public abstract class PedidoEntity : BaseEntity
    {

        public int IdUsuario { get; set; }
        public List<LivroEntity> Livros { get; set; }
        public decimal Total
        {
            get
            {
                decimal soma = 0;
                foreach (var livro in Livros)
                {
                    soma += livro.Preco;
                }
                return soma;
            }
        }
    }
}
