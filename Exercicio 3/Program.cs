public class Program
{
	static void Main(string[] args)
	{
		Empregado a = new Empregado("Sthefany", 1000.00, new DateTime(2023,02,04));
		a.AumentoSalarial(10);

        Empregado b = new Empregado("Natália", 2000.00, new DateTime(2021, 06, 22));
        b.AumentoSalarial(10);

        Console.WriteLine($"\nSoma do salário dos funcionários = {Empregado.GetSomaSalarios()}");
	}
}