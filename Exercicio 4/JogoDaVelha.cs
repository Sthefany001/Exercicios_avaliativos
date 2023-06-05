using System;

enum Ocupacao
{
    Vazia,
    Jogador1,
    Jogador2
}

public class JogoDaVelha
{
    private Ocupacao[,] grade;

    public JogoDaVelha()
    {
        grade = new Ocupacao[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                grade[i, j] = Ocupacao.Vazia;
            }
        }
    }

    public void ExibirGrade()
    {
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                if (grade[i, j] == Ocupacao.Vazia)
                {
                    Console.Write("- ");
                }
                else if (grade[i, j] == Ocupacao.Jogador1)
                {
                    Console.Write("X ");
                }
                else if (grade[i, j] == Ocupacao.Jogador2)
                {
                    Console.Write("O ");
                }
            }
            Console.WriteLine();
        }
    }

    public void Jogar()
    {
        Ocupacao jogadorAtual = Ocupacao.Jogador1;
        int jogadas = 0;
        while (true)
        {
            Console.WriteLine("Bem-vindo ao jogo da velha!");
            Console.WriteLine("Jogador 1: X");
            Console.WriteLine("Jogador 2: O\n");
           
            Console.WriteLine("Jogador " + (int)jogadorAtual + ", faça sua jogada.");
            Console.Write("Linha: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Coluna: ");
            int coluna = int.Parse(Console.ReadLine());
            if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2)
            {
                Console.WriteLine("Jogada inválida. Tente novamente.");
                continue;
            }
            if (grade[linha, coluna] != Ocupacao.Vazia)
            {
                Console.WriteLine("Esta casa já está ocupada. Tente novamente.");
                continue;
            }
            grade[linha, coluna] = jogadorAtual;
            jogadas++;
            ExibirGrade();
            if (VerificarVitoria(jogadorAtual))
            {
                Console.WriteLine("Jogador " + (int)jogadorAtual + " venceu!");
                return;
            }
            if (jogadas == 9)
            {
                Console.WriteLine("Empate!");
                return;
            }
            jogadorAtual = jogadorAtual == Ocupacao.Jogador1 ? Ocupacao.Jogador2 : Ocupacao.Jogador1;
        }
    }

    private bool VerificarVitoria(Ocupacao jogador)
    {
        // Verifica as linhas
        for (int i = 0; i < 3; i++)
        {
            if (grade[i, 0] == jogador && grade[i, 1] == jogador && grade[i, 2] == jogador)
            {
                return true;
            }
        }
        // Verifica as colunas
        for (int j = 0; j < 3; j++)
        {
            if (grade[0, j] == jogador && grade[1, j] == jogador && grade[2, j] == jogador)
            {
                return true;
            }
        }
        // Verifica as diagonais
        if (grade[0, 0] == jogador && grade[1, 1] == jogador && grade[2, 2] == jogador)
        {
            return true;
        }
        if (grade[0, 2] == jogador && grade[1, 1] == jogador && grade[2, 0] == jogador)
        {
            return true;
        }
        return false;
    }
}
