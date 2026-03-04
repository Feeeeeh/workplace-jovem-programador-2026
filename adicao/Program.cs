internal class Program

{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) a calculadora de soma\r\nInsira o primeiro numero");
        int primeiro = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("insira o segundo numero");
        int segundo = int.Parse(Console.ReadLine());
        int resultado = primeiro + segundo;
        Console.WriteLine("Resultado: " + resultado);
    }
}