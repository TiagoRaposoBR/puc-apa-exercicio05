using System.Collections.Generic;

namespace puc_apa_exercicio05.Domain.Entities
{
    public abstract class CarrinhoEntity : BaseEntity
    {
        public int Id_Usuario { get; set; }
        public List<LivroEntity> Livros { get; set; }
    }
}
