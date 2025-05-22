public class Aluno : Usuario
{
    public string Curso { get; set; }
    public string Matricula { get; set; }

    public Aluno(string nome, int id, string curso, string matricula)
        : base(nome, id, "Aluno")
    {
        Curso = curso;
        Matricula = matricula;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Aluno] Nome: {Nome} | ID: {Id} | Curso: {Curso} | Matrícula: {Matricula}");
    }
}
