using System;
using System.Collections.Generic;

class Notas
{
    static void Main(string[] args)
    {
        // try { Console.Clear(); } catch { } não consegui fazer funcionar sla

        Console.WriteLine(" SISTEMA DE NOTAS");

        // listas dinamicas dos nomes e medias dos alunos
        List<string> nomes = new List<string>();
        List<double> medias = new List<double>();

        // loop do programa pra que ele só termine quando o usuario decidir
        while (true)
        {
            Console.Write("\nQuantos alunos deseja adicionar? ");
            int qtdNovos = int.Parse(Console.ReadLine());

            // coleta os dados dos alunos, calcula a média e guarda em listas
            for (int i = 0; i < qtdNovos; i++)
            {
                Console.WriteLine($"Cadastro: Aluno {nomes.Count + 1}");
                Console.Write(" Nome: ");
                string nome = Console.ReadLine();

                double somaNotas = 0;

                // coleta as notas das 4 provas, com valor decimal
                for (int j = 1; j <= 4; j++)
                {
                    double nota = -1;
                    while (nota < 0 || nota > 10)
                    {
                        Console.Write($" Nota {j}: ");
                        nota = double.Parse(Console.ReadLine());

                        // garante notas até 10
                        if (nota < 0 || nota > 10)
                        {
                            Console.WriteLine(" Nota inválida! Digite um valor entre 0 e 10.");
                            nota = -1; // força o loop a continuar
                        }
                    }
                    somaNotas += nota;
                }

                nomes.Add(nome);
                medias.Add(somaNotas / 4.0);
            }

            // lista de índices, ordena por média
            List<int> indices = new List<int>();
            for (int i = 0; i < nomes.Count; i++)
                indices.Add(i);

            indices.Sort((a, b) => medias[b].CompareTo(medias[a]));

            Console.WriteLine(" RESULTADO ATUAL");
            Console.WriteLine($" {"#",-3} | {"Nome",-16} | {"Média",-6} | Situação");

            for (int i = 0; i < nomes.Count; i++)
            {
                int ind = indices[i];
                string situacao = medias[ind] >= 7 ? "APROVADO" : "REPROVADO";

                Console.WriteLine($" {i+1,-3} | {nomes[ind],-16} | {medias[ind],4:F1} | {situacao}");

                /*
                os numeros entre chaves são pra formatar a saída
                o -3 é pra alinhar a esquerda e reservar 3 caracteres, o 4:F1 é pra mostrar 1 casa decimal e reservar 4 caracteres
                */
            }

            Console.WriteLine("---------------------------------------------");

            // loop pra ou adicionar mais alunos ou encerrar o programa
            string resposta = "";
            while (resposta != "s" && resposta != "n")
            {
                Console.Write("\nDeseja adicionar mais alunos? (s/n): ");
                resposta = Console.ReadLine().ToLower();

                if (resposta != "s" && resposta != "n")
                    Console.WriteLine("Input inválido! Digite apenas S ou N.");
            }

            if (resposta == "n")
            {
                Console.WriteLine("\nPrograma encerrado.");
                break;
            }
        }
    }
}