public class Program
{
	static void Main(string[] args)
	{
		Terreno t = new Terreno(8, 15);

		t.Area();

		Console.WriteLine($"\nValor estimado do terreno = R${t.ValorEstimado(1684.45).ToString("0.00")}");
		
	}
}