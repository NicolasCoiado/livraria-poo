namespace Classes;

public class Artigo : Livro
{
    public string universidade { get; set; }

    public Artigo(string nomeLivro, string autorLivro, string editoraLivro, string universidade)
    : base(nomeLivro, autorLivro, editoraLivro)
    {
        this.universidade = universidade;
    }
}