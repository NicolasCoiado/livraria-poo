namespace Classes;

public class Emprestimo
{
    private static int proximoID = 1;
    public int idEmprestimo;
    public int idDevedor { get; set; }
    public int[] livrosEmprestimo { get; set; }
    public DateTime dataDevolucao { get; set; }
    public bool statusEmprestimo { get; set; }

    public Emprestimo(int[] livrosEmprestimo, int idDevedor, DateTime dataDevolucao, bool statusEmprestimo)
    {
        idEmprestimo = proximoID;
        proximoID++;

        this.livrosEmprestimo = livrosEmprestimo;
        this.idDevedor = idDevedor;
        this.dataDevolucao = dataDevolucao;
        this.statusEmprestimo = statusEmprestimo;
    }
}