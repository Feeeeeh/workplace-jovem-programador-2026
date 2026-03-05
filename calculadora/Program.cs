﻿internal class Program

{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) a calculadora");
        while (true)
        {
            Console.WriteLine("Qual operação gostaria de realizar?\n");
            Console.WriteLine(@"
[1] Soma
[2] Subtração
[3] Multiplicão
[4] Divisão
[5] Resto
[6] Sair do Programa
                ");
            int operacao = Convert.ToInt32(Console.ReadLine());

            if (operacao == 6)
                break;
            else
            {
                Console.WriteLine("insira o primeiro numero");
                int primeiro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("insira o segundo numero");
                int segundo = Convert.ToInt32(Console.ReadLine());
                
                if (operacao == 1) //soma 
                {
                    int resultado = primeiro + segundo;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else if (operacao == 2) //subtração
                {
                    int resultado = primeiro - segundo;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else if (operacao == 3) //multiplição
                {
                    int resultado = primeiro * segundo;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else if (operacao == 4) //divisão
                {
                    int resultado = primeiro / segundo;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else if (operacao == 5) //resto
                {
                    int resultado = primeiro % segundo;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("Input invalido");
                }
            }
        }
    }
}