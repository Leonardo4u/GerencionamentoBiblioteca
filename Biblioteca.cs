public class Biblioteca
{
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Livro> livros = new List<Livro>();
    private List<Emprestimo> emprestimos = new List<Emprestimo>();

    public void CadastrarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    public void RealizarEmprestimo(int idUsuario, string isbn)
    {
        Usuario usuarioEncontrado = null;
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.Id == idUsuario)
            {
                usuarioEncontrado = usuario;
                break;
            }
        }

        Livro livroEncontrado = null;
        foreach (Livro livro in livros)
        {
            if (livro.ISBN == isbn && livro.Disponivel)
            {
                livroEncontrado = livro;
                break;
            }
        }

        if (usuarioEncontrado == null || livroEncontrado == null)
        {
            Console.WriteLine(" Usuário não encontrado ou livro indisponível.");
            return;
        }

        Emprestimo emprestimo = new Emprestimo(usuarioEncontrado, livroEncontrado);
        emprestimos.Add(emprestimo);
        Console.WriteLine(" Empréstimo realizado com sucesso!");
    }

    public void RegistrarDevolucao(string isbn)
    {
        Emprestimo emprestimoEncontrado = null;
        foreach (Emprestimo emprestimo in emprestimos)
        {
            if (emprestimo.Livro.ISBN == isbn && emprestimo.Ativo)
            {
                emprestimoEncontrado = emprestimo;
                break;
            }
        }

        if (emprestimoEncontrado != null)
        {
            emprestimoEncontrado.RegistrarDevolucao();
            Console.WriteLine(" Devolução registrada.");
        }
        else
        {
            Console.WriteLine(" Nenhum empréstimo ativo para este ISBN.");
        }
    }

    public void ListarLivrosDisponiveis()
    {
        Console.WriteLine("\n Livros Disponíveis:");
        foreach (Livro livro in livros)
        {
            if (livro.Disponivel)
            {
                livro.ExibirInformacoes();
            }
        }
    }

    public void ListarUsuarios()
    {
        Console.WriteLine("\n Usuários Cadastrados:");
        foreach (Usuario usuario in usuarios)
        {
            usuario.ExibirInformacoes();
        }
    }

    public void ListarEmprestimos()
    {
        Console.WriteLine("\n Histórico de Empréstimos:");
        foreach (Emprestimo emprestimo in emprestimos)
        {
            emprestimo.ExibirResumo();
        }
    }

    public void ListarLivrosEmprestados()
    {
        Console.WriteLine("\n Livros Emprestados:");
        foreach (Livro livro in livros)
        {
            if (!livro.Disponivel)
            {
                livro.ExibirInformacoes();
            }
        }
    }
}
