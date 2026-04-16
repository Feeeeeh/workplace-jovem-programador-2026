class Veiculo
{
    private int velocidade = 0;

    public void AumentarVelocidade(int aumento)
    {
        if (velocidade + aumento > 240)
        {
            Console.WriteLine("O carro não pode ir além de 240 km/h.");
            return;
        }
        for (int i = 0; i < aumento; i++)
        {
            velocidade++;
        }
        Console.WriteLine($"Velocidade atual: {velocidade} km/h");

    }

    public void DiminuirVelocidade(int diminuição)
    {
        if (velocidade - diminuição < 0)
        {
            Console.WriteLine("Valor inserido muito alto. Velocidade definida para 0 km/h.");
            velocidade = 0;
            return;
        }
        for (int i = 0; i < diminuição; i++)
        {
            velocidade--;
        }
        Console.WriteLine($"Velocidade atual: {velocidade} km/h");
    }

    public void VelocidadeAtual()
    {
        Console.WriteLine($"Velocidade Atual: {velocidade}");
    }    
}