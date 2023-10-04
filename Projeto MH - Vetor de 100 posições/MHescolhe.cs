using System;
using System.Collections.Generic;

class MHescolhe
{
    static Random random = new Random();
    static List<int> listaTabu = new List<int>();
    static int melhorSoma;
    static int[] melhorSolucao;

    public static void InicializaVetor(int[] vetor)
    {
        // Inicializa o vetor com 6 zeros e o restante com 10
        for (int i = 0; i < 6; i++)
        {
            vetor[i] = 0;
        }
        for (int i = 6; i < vetor.Length; i++)
        {
            vetor[i] = 10;
        }
        // Embaralha o vetor
        for (int i = vetor.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            int temp = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = temp;
        }
    }

    public static int SomaVetor(int[] vetor)
    {
        int soma = 0;
        foreach (int valor in vetor)
        {
            soma += valor;
        }
        return soma;
    }

    public static int ContaZerosEmPrimos(int[] vetor)
    {
        int contagem = 0;
        bool[] numerosPrimos = new bool[100];

        for (int i = 2; i < vetor.Length; i++)
        {
            if (!numerosPrimos[i])
            {
                for (int j = i * i; j < vetor.Length; j += i)
                {
                    numerosPrimos[j] = true;
                }
            }
        }

        for (int i = 2; i < vetor.Length; i++)
        {
            if (!numerosPrimos[i] && vetor[i] == 0)
            {
                contagem++;
            }
        }

        return contagem;
    }

    public static void AplicaAcao(int[] vetor, int posicao)
    {
        vetor[posicao] = 10 - vetor[posicao];
    }

    public static void BuscaTabu_escolhe(int[] vetor)
    {
        melhorSoma = SomaVetor(vetor);
        melhorSolucao = (int[])vetor.Clone();
        int iteracoesSemMelhora = 0;
        int iteracoesMaximasSemMelhora = 100;

        Console.WriteLine("\nPressione Enter para começar a execução...");
        Console.ReadLine();

        while (iteracoesSemMelhora < iteracoesMaximasSemMelhora)
        {
            int[] vizinho = (int[])vetor.Clone();
            int aleatorio = random.Next(vizinho.Length);
            AplicaAcao(vizinho, aleatorio);
            int somaVizinho = SomaVetor(vizinho);
            int bonus = (ContaZerosEmPrimos(vizinho) > 0) ? (int)Math.Pow(2, ContaZerosEmPrimos(vizinho)) : 0;
            int somaTotal = somaVizinho + bonus;

            if (somaTotal > melhorSoma)
            {
                AplicaAcao(vetor, aleatorio);
                listaTabu.Add(aleatorio);
                melhorSoma = somaTotal;
                iteracoesSemMelhora = 0;
            }
            else
            {
                iteracoesSemMelhora++;
            }

            Console.WriteLine("\nIteração " + iteracoesSemMelhora);
            Console.WriteLine("Ação realizada na posição " + aleatorio);
            Console.WriteLine("Novo Vetor: " + string.Join(" ", vetor));
            Console.WriteLine("Soma da Melhor Solução: " + melhorSoma);
            Console.WriteLine("Quantidade de Zeros em Posições Primas: " + ContaZerosEmPrimos(vetor));
            Console.WriteLine("Soma Total: " + somaTotal);
        }

        Console.WriteLine("\nPressione Enter para encerrar...");
        Console.ReadLine();
    }
}


