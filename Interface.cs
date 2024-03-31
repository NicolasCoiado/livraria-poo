using Classes;

public class Interface
{
    public short Apresentacao()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo à Livraria Orientada a Objetos!");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Cadastrar usuário.");
        Console.WriteLine("2 - Cadastrar livro.");
        Console.WriteLine("3 - Cadastrar artigo científico.");
        Console.WriteLine("4 - Realizar empréstimo.");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("========================================");
        short opcao = short.Parse(Console.ReadLine());
        return opcao;
    }
    public Devedor CadastrarUsuario()
    {
        Console.WriteLine("Digite o nome do usuário.");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o email do usuário.");
        string email = Console.ReadLine();
        Console.WriteLine("Digite o endereço do usuário.");
        string endereco = Console.ReadLine();

        var devedor = new Devedor(nome, email, endereco);
        return devedor;
    }
    public Livro CadastrarLivro()
    {
        Console.WriteLine("Digite o nome do livro.");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o nome do autor do livro.");
        string autor = Console.ReadLine();
        Console.WriteLine("Digite o nome da editora do livro.");
        string editora = Console.ReadLine();

        var livro = new Livro(nome, autor, editora);
        return livro;
    }

    public Artigo CadastrarArtigo()
    {
        Console.WriteLine("Digite o nome do livro.");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o nome do autor do livro.");
        string autor = Console.ReadLine();
        Console.WriteLine("Digite o nome da editora do livro.");
        string editora = Console.ReadLine();
        Console.WriteLine("Digite o nome da universidade do livro.");
        string universidade = Console.ReadLine();

        var artigo = new Artigo(nome, autor, editora, universidade);
        return artigo;
    }
    public Emprestimo Emprestar()
    {
        Console.WriteLine("Digite o código dos livros que deseja emprestar. Ex: 1, 2, 3");
        string idsLivros = Console.ReadLine();
        string[] codigos = idsLivros.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        int[] livros = Array.ConvertAll(codigos, int.Parse);

        Console.WriteLine("Digite o código do usuário que irá pegar o livro.");
        short idDevedor = short.Parse(Console.ReadLine());

        Console.WriteLine("Digite a data de devolução do livro. Ex: 10/12/2023");
        string dataString = Console.ReadLine();
        string formatoData = "dd/MM/yyyy";

        bool statusEmprestimo = true;

        DateTime dataDevolucao;

        dataDevolucao = DateTime.ParseExact(dataString, formatoData, null);
        var emprestimo = new Emprestimo(livros, idDevedor, dataDevolucao, statusEmprestimo);
        return emprestimo;
    }
}