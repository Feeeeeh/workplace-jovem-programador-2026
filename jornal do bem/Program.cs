while (true)
{
    Console.WriteLine("Jornal do Bem - Notícias do dia\n");
    Console.WriteLine("Escolha uma noticia");
    Console.WriteLine("1 - Senado Federal aprova projeto que torna misoginia crime equivalente ao de racismo");
    Console.WriteLine("2 - Gato Naruto: delegacia no Chile ganha reforço felino");
    Console.WriteLine("3 - Sair\n");
    string? escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1":
            MisoginiaViraCrime();
            continuar();
            break;
        case "2":
            GatoNaruto();
            continuar();
            break;
        case "3":
            Console.WriteLine("Saindo...");
            return;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha 1, 2 ou 3.");
            await Task.Delay(2000);
            Console.Clear();
            break;
    }
}
void MisoginiaViraCrime()
{
    Console.WriteLine("Senado Federal aprova projeto que torna misoginia crime equivalente ao de racismo\n");
    Console.WriteLine(@"
O Senado Federal aprovou um projeto de lei que torna a misoginia um crime equivalente ao de racismo.
A proposta, que agora segue para sanção presidencial, visa combater a discriminação e violência contra as mulheres, 
reconhecendo a misoginia como uma forma de preconceito e opressão. Com essa medida, espera-se fortalecer a proteção dos 
direitos das mulheres e promover uma sociedade mais justa e igualitária.");
}
void GatoNaruto()
{
    Console.WriteLine("Gato Naruto: delegacia no Chile ganha reforço felino\n");
    Console.WriteLine(@"
Um gato resgatado das ruas se tornou o mais novo integrante de uma delegacia na cidade de Porvenir, no Chile,
onde ganhou não apenas um lar, mas também um papel especial no acolhimento de vítimas de crimes.

O felino, batizado de Naruto, foi encontrado por um policial em um momento de vulnerabilidade, 
quando fugia assustado de cachorros em um dia particularmente frio. Sensibilizado com a situação do animal, 
o agente decidiu resgatá-lo e levá-lo para a delegacia.");
}
void continuar()
{
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
}