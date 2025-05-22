using System;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        bool sair = false;

        while (!sair)
        {
            Console.Clear(); // Limpa a tela 

            // Exibe o menu principal
            Console.WriteLine("\n******************************************************");
            Console.WriteLine("\n===== Sistema de Biblioteca Anhembi Morumbi =====");
            Console.WriteLine("\n******************************************************");
            Console.WriteLine("1. Cadastrar Livro");
            Console.WriteLine("2. Cadastrar Aluno");
            Console.WriteLine("3. Cadastrar Professor");
            Console.WriteLine("4. Realizar Empréstimo");
            Console.WriteLine("5. Registrar Devolução");
            Console.WriteLine("6. Relatórios");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            // Executa a opção escolhida
            if (opcao == "1")
            {
                CadastrarLivro(biblioteca);
            }
            else if (opcao == "2")
            {
                CadastrarAluno(biblioteca);
            }
            else if (opcao == "3")
            {
                CadastrarProfessor(biblioteca);
            }
            else if (opcao == "4")
            {
                RealizarEmprestimo(biblioteca);
            }
            else if (opcao == "5")
            {
                RegistrarDevolucao(biblioteca);
            }
            else if (opcao == "6")
            {
                MostrarRelatorios(biblioteca);
            }
            else if (opcao == "0")
            {
                sair = true;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }

    // Função para cadastrar um livro
    static void CadastrarLivro(Biblioteca biblioteca)
    {
        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());

        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();

        Livro livro = new Livro(titulo, autor, ano, isbn);
        biblioteca.CadastrarLivro(livro);

        Console.WriteLine("Livro cadastrado com sucesso!");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    // Função para cadastrar um aluno
    static void CadastrarAluno(Biblioteca biblioteca)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        string curso = Console.ReadLine();

        Console.Write("Matrícula: ");
        string matricula = Console.ReadLine();

        Aluno aluno = new Aluno(nome, id, curso, matricula);
        biblioteca.CadastrarUsuario(aluno);

        Console.WriteLine("Aluno cadastrado com sucesso!");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    // Função para cadastrar um professor
    static void CadastrarProfessor(Biblioteca biblioteca)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Departamento: ");
        string departamento = Console.ReadLine();

        Console.Write("Registro: ");
        string registro = Console.ReadLine();

        Professor professor = new Professor(nome, id, departamento, registro);
        biblioteca.CadastrarUsuario(professor);

        Console.WriteLine("Professor cadastrado com sucesso!");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    // Função para realizar um empréstimo
    static void RealizarEmprestimo(Biblioteca biblioteca)
    {
        Console.Write("ID do Usuário: ");
        int idUsuario = int.Parse(Console.ReadLine());

        Console.Write("ISBN do Livro: ");
        string isbn = Console.ReadLine();

        biblioteca.RealizarEmprestimo(idUsuario, isbn);

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    // Função para registrar devolução de livro
    static void RegistrarDevolucao(Biblioteca biblioteca)
    {
        Console.Write("ISBN do Livro a devolver: ");
        string isbn = Console.ReadLine();

        biblioteca.RegistrarDevolucao(isbn);

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    // Função para mostrar relatórios
    static void MostrarRelatorios(Biblioteca biblioteca)
    {
        biblioteca.ListarLivrosDisponiveis();
        biblioteca.ListarUsuarios();
        biblioteca.ListarEmprestimos();
        biblioteca.ListarLivrosEmprestados();

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
}
