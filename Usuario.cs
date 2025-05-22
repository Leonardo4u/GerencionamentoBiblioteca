public abstract class Usuario
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public string Tipo { get; set; }

    public Usuario(string nome, int id, string tipo)
    {
        Nome = nome;
        Id = id;
        Tipo = tipo;
    }

    public abstract void ExibirInformacoes();
}
