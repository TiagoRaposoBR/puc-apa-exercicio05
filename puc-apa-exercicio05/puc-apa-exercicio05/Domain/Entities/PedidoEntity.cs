using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace puc_apa_exercicio05.Domain.Entities
{
    public abstract class PedidoEntity : BaseEntity
    {
        private int IdUsuario { get; set; }
        public List<LivroEntity> Livros { get; set; }
        public int Total
        {
            get
            {
                var soma = 0;
                foreach (var livro in Livros)
                {
                    soma += livro.Preco;
                }
                return soma;
            }
        }
    }
}
