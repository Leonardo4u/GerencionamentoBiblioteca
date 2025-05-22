public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public string ISBN { get; set; }
    private bool disponivel = true;

    public bool Disponivel
    {
        get { return disponivel; }
    }

    public Livro(string titulo, string autor, int ano, string isbn)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        ISBN = isbn;
    }

    public void MarcarComoEmprestado()
    {
        disponivel = false;
    }

    public void MarcarComoDevolvido()
    {
        disponivel = true;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Ano: {Ano} | ISBN: {ISBN} | Status: {(Disponivel ? "Disponível" : "Emprestado")}");
    }
}
