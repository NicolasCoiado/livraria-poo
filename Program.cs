using Classes;
metodo();

void metodo()
{

    List<Devedor> devedores = [];
    List<Livro> livros = [];
    List<Artigo> artigos = [];
    List<Emprestimo> emprestimos = [];
    var menu = new Interface();

    var opcao = menu.Apresentacao();
    switch (opcao)
    {
        case 0: System.Environment.Exit(0); break;
        case 1:
            var novoDevedor = menu.CadastrarUsuario();
            devedores.Add(novoDevedor);
            metodo();
            break;
        case 2:
            var novoLivro = menu.CadastrarLivro();
            livros.Add(novoLivro);
            metodo();
            break;
        case 3:
            var novoArtigo = menu.CadastrarArtigo();
            artigos.Add(novoArtigo);
            metodo();
            break;
        case 4:
            var novoEmprestimo = menu.Emprestar();
            emprestimos.Add(novoEmprestimo);
            metodo();
            break;
        default: menu.Apresentacao(); break;
    }
}



