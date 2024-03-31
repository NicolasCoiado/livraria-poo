namespace Classes;

public class Livro
{
    private static int proximoID = 1;
    public int idLivro;
    public string nomeLivro { get; set; }
    public string autorLivro { get; set; }
    public string editoraLivro { get; set; }

    public Livro(string nomeLivro, string autorLivro, string editoraLivro)
    {
        idLivro = proximoID;
        proximoID++;

        this.nomeLivro = nomeLivro;
        this.autorLivro = autorLivro;
        this.editoraLivro = editoraLivro;
    }
}