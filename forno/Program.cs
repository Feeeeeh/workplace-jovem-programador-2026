while (true)
{
    int temp = 0;
    Console.WriteLine("[1] Definir temperatura do forno \n[2] Sair");
    int escolha = Convert.ToInt32(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            Console.WriteLine("Escolha a temperatura desejada");
            int tempFinal = Convert.ToInt32(Console.ReadLine());
            if (tempFinal >= 0)
            {
                while (temp<tempFinal)
                {
                    Console.WriteLine($"Temperatura Atual: {temp}");
                    temp += 20;
                    await Task.Delay(1000);
                }
                Console.WriteLine($"A temperatura do forno parou em {temp}");
            }
            else 
            {
                Console.WriteLine("Digite um número positivo");
            }
        break;

        case 2:
            System.Environment.Exit(0);
        break;
    }
}