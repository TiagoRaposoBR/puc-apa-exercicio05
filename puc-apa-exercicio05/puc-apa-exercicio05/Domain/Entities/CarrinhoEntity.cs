using System.Collections.Generic;

namespace puc_apa_exercicio05.Domain.Entities
{
    public class CarrinhoEntity : BaseEntity
    {
        public int IdUsuario { get; set; }
        public List<LivroEntity> Livros { get; set; }

        public CarrinhoEntity(UsuarioEntity usuario, LivroEntity primeiroItem)
        {
            IdUsuario = usuario.Id;
            Livros = new List<LivroEntity>() { primeiroItem };
        }

        public void AdicionarLivro(LivroEntity livro)
        {
            Livros.Add(livro);
        }

        public void RemoverLivro(int livroIdARemover)
        {
            Livros.RemoveAll(livro => livro.Id == livroIdARemover);
        }
    }
}
