public class Terreno
{
    private double largura;
    private double comprimento;

    public Terreno(double largura, double comprimento)
    {
        this.largura = largura;
        this.comprimento = comprimento;
    }
    public double GetLargura()
    {
        return this.largura;
    }
    public void SetLargura()
    {

    }

    public double GetComprimento()
    {
        return this.comprimento;
    }
    public void SetComprimento()
    {

    }

    public void Area()
    {
        double area = this.largura * this.comprimento;
        Console.WriteLine($"\nÁrea do terreno = {area}m²");
    }

    public double ValorEstimado(double x)
    {
        double valor = x * (this.largura * this.comprimento);
        return valor;
    }
}
