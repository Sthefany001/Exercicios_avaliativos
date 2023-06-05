public class Empregado
{
    private string nome;
    private double salario;
    private DateTime dataAdm;
    private static double somaSalarios;
    public Empregado(string nome, double salario, DateTime dataAdm)
    {
        this.nome = nome;
        this.salario = salario;
        this.dataAdm = dataAdm;
        somaSalarios += salario;
    }

    public string GetNome()
    {
        return this.nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public double GetSalario()
    {
        return this.salario;
    }
    public void SetSalario(double salario)
    {
        this.salario = salario;
    }

    public DateTime GetdataAdm()
    {
        return this.dataAdm;
    }
    public void SetDataAdm(DateTime dataAdm)
    {
        this.dataAdm = dataAdm;
    }

    public void AumentoSalarial(int x)
    {
        double aumento = (this.salario / 100) * x;
        somaSalarios += aumento;
        this.salario += aumento;
        Console.WriteLine($"\nAumento do salário = {aumento} \nSalário atual = {this.salario}");
    }

    public static double GetSomaSalarios()
    {
        return somaSalarios;
    }
}
