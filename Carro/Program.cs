using System.Threading.Tasks;

await Main();

async Task Main()
{
Motorista motorista1 = new Motorista();
motorista1.SetarCNH("123456789");
motorista1.nome = "João";
motorista1.idade = 30;

Carro carro1 = new Carro();

static async Task Limpar()
{
    Thread.Sleep(1500);
    Console.WriteLine("Aperte ENTER para continuar");
    Console.ReadLine();
    Console.Clear();
}

while (true)
{
    Console.WriteLine("Simulador de Direção\nEscolha uma opção:\n");

    carro1.VelocidadeAtual();
    Console.WriteLine("1. Acelerar");
    Console.WriteLine("2. Frear");
    Console.WriteLine("3. Sair");

    string escolha = Console.ReadLine() ?? "";
    switch (escolha)
    {
        case "1":
            int aumento = motorista1.Acelerar();
            carro1.AumentarVelocidade(aumento);
            await Limpar();
            break;
        case "2":
            int diminuição = motorista1.Frear();
            carro1.DiminuirVelocidade(diminuição);
            await Limpar();
            break;
        case "3":
            Console.WriteLine("Saindo...");
            Task.Delay(2000).Wait();
            Console.Clear();
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            await Limpar();
            break;
    }
}
}
