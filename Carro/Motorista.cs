class Motorista
{
    private int cnh;
    public string? nome;
    public int idade;

    public void SetarCNH(string valor)
    {
        int count = valor.Length;
        if (count == 9)
        {
            cnh = int.Parse(valor);
        }
    }

    public int Acelerar()
    {
        Console.WriteLine("Quanto gostaria de acelerar em km/h?");
        int aumentar = int.Parse(Console.ReadLine() ??"");
        return aumentar;
    }

    public int Frear()
    {
        Console.WriteLine("Quanto gostaria de acelerar em kh/h?");
        int diminuir = int.Parse(Console.ReadLine() ??"");
        return diminuir;
    }
}