public class Professor : Usuario
{
    public string Departamento { get; set; }
    public string Registro { get; set; }

    public Professor(string nome, int id, string departamento, string registro)
        : base(nome, id, "Professor")
    {
        Departamento = departamento;
        Registro = registro;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Professor] Nome: {Nome} | ID: {Id} | Departamento: {Departamento} | Registro: {Registro}");
    }
}
