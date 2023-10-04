using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[100];

        Console.WriteLine("Escolha o comportamento da metaheurística:");
        Console.WriteLine("1. Escolha de Números (0 ou 10)");
        Console.WriteLine("2. Troca de Posições entre 0 e 10");
        int escolhaComportamento = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a estratégia de metaheurística:");
        Console.WriteLine("1. Busca Tabu");
        // Adicionarei mais estratégias aqui

        int escolhaEstrategia = int.Parse(Console.ReadLine());

        switch (escolhaComportamento)
        {
            case 1:
                if (escolhaEstrategia == 1) // Busca Tabu Escolhe
                {
                    Console.WriteLine("Metaheurística: Escolha de Números com Busca Tabu");
                    MHescolhe.InicializaVetor(vetor); // Modificar
                    Console.WriteLine("Vetor Inicial:");
                    Console.WriteLine(string.Join(" ", vetor));
                    MHescolhe.BuscaTabu_escolhe(vetor);
                }
                // Adicione outras estratégias aqui, se necessário
                break;

            case 2:
                if (escolhaEstrategia == 1) // Busca Tabu troca
                {
                    Console.WriteLine("Metaheurística: Troca de Posições com Busca Tabu");
                    MHtroca.InicializaVetor(vetor);
                    Console.WriteLine("Vetor Inicial:");
                    Console.WriteLine(string.Join(" ", vetor));
                    MHtroca.BuscaTabu_troca(vetor);
                }
                // Adicione outras estratégias aqui, se necessário
                break;
        }

        Console.ReadLine();
    }
}



