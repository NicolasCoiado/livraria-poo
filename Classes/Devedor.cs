namespace Classes;

public class Devedor
{
    private static int proximoID = 1;
    public int idDevedor;
    public string nomeDevedor { get; set; }
    public string email { get; set; }
    public string endereco { get; set; }
    public Emprestimo? emprestimo { get; set; }
    public Devedor(string nomeDevedor, string email, string endereco) //Método construtor
    {
        idDevedor = proximoID;
        proximoID++;

        this.nomeDevedor = nomeDevedor;
        this.email = email;
        this.endereco = endereco;
    }
}