public class Emprestimo
{
    public Usuario Usuario { get; set; }
    public Livro Livro { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime? DataDevolucao { get; private set; }

    public bool Ativo => DataDevolucao == null;

    public Emprestimo(Usuario usuario, Livro livro)
    {
        Usuario = usuario;
        Livro = livro;
        DataEmprestimo = DateTime.Now;
        livro.MarcarComoEmprestado();
    }

    public void RegistrarDevolucao()
    {
        DataDevolucao = DateTime.Now;
        Livro.MarcarComoDevolvido();
    }

    public void ExibirResumo()
    {
        string status = Ativo ? "Ativo" : "Concluído";
        Console.WriteLine($"Usuário: {Usuario.Nome} | Livro: {Livro.Titulo} | Empréstimo: {DataEmprestimo} | Devolução: {(DataDevolucao.HasValue ? DataDevolucao.ToString() : "Pendente")} | Status: {status}");
    }
}
