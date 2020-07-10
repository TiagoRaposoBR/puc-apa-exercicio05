using System.Collections.Generic;

namespace puc_apa_exercicio05.Domain.Entities
{
    public abstract class CarrinhoEntity : BaseEntity
    {
        public int IdUsuario { get; set; }
        public List<LivroEntity> Livros { get; set; }

        public int CriarCarrinho(UsuarioEntity usuario, LivroEntity primeiroItem)
        {
            IdUsuario = usuario.Id;
            Livros = new List<LivroEntity>() { primeiroItem };
        }

        public int AdicionarLivro(LivroEntity livro)
        {
            Livros.Add(livro);
        }

        public int RemoverLivro(int livroIdARemover)
        {
            Livros.RemoveAll(livro => livro.Id == livroIdARemover);
        }
    }
}
