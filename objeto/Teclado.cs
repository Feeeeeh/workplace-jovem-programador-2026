class Teclado
{
    public int tamanho;
    public int numTeclas;
    public string? cor;
    public string? marca;
    public string? tipo;
    public bool fio;
    public bool led;

    public void Digitar()
    {
        Console.WriteLine("Digitando");
    }

    public void Deletar()
    {
        Console.WriteLine("Deletado");
    }

    public void Enviar()
    {
        Console.WriteLine("Enviado");
    }

    public void TrocarTela()
    {
        Console.WriteLine("Tela trocada");
    }

    public void Capslock()
    {
        Console.WriteLine("Capslock on/off");
    }

}