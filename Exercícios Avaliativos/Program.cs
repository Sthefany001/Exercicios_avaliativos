using System;

public class Program
{
	static void Main(string[] args)
	{
		Matematica teste = new Matematica();

		while(true)
		{
			Console.WriteLine("\nMenu: ");
			Console.WriteLine("0 - Fechar programa.");
			Console.WriteLine("1 - Soma de dois números.");
			Console.WriteLine("2 - Maior valor entre dois números.");
			Console.WriteLine("3 - Raiz quadrada de um número.");
			Console.Write("Opção escolhida: ");
			int opcao = Convert.ToInt32(Console.ReadLine());

			switch (opcao)
			{
                case 0:
                    Console.WriteLine("\nObrigada por usar meu programa! :D");
                    goto exit;
					//break;
                case 1:
					Console.Write("\nDigite o 1º número: ");
					double n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o 2º número: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"SOMA = {teste.Somar(n1, n2)}");
					break;
				case 2:
                    Console.Write("\nDigite o 1º número: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o 2º número: ");
                    double b = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine($"MAIOR = {teste.Maior(a, b)}");
                    break;
				case 3:
					Console.Write("\nDigite um número: ");
					double x = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine($"RAIZ QUADRADA = {teste.RaizQuadrada(x)}");
					break;
					default:
					Console.WriteLine("\nOpção inválida!");
					break;
						
			}

		}
		exit:;
	}
}
