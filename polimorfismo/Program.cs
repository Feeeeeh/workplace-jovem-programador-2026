while (true)
{
    Console.Clear();
    Console.WriteLine("Escolha o formato de exportação:");
    Console.WriteLine("1 - Arquivo padrão");
    Console.WriteLine("2 - PDF");
    Console.WriteLine("3 - CSV");
    Console.WriteLine("4 - JSON");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");

    string? opcao = Console.ReadLine();
    Arquivo arquivo;

    switch (opcao)
    {
        case "1":
            arquivo = new Arquivo();
            break;
        case "2":
            arquivo = new Pdf();
            break;
        case "3":
            arquivo = new Csv();
            break;
        case "4":
            arquivo = new Json();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Opção inválida. Pressione ENTER para tentar novamente.");
            Console.ReadLine();
            continue;
    }

    arquivo.exportar();
    Console.WriteLine("Pressione ENTER para continuar.");
    Console.ReadLine();
}
