var dicExtenso = new Dictionary<int, string>
{
    {1,"Um"},
    {2,"Dois"},
    {3,"Três"},
    {4,"Quatro"},
    {5,"Cinco"},
    {6,"Seis"},
    {7,"Sete"},
    {8,"Oito"},
    {9,"Nove"},
    {10,"Dez"}
};

Console.WriteLine("Digite um número entre 1 e 10 para recebe-lo por extenso");
int numero = Convert.ToInt32(Console.ReadLine());

if (dicExtenso.TryGetValue(numero, out string? extenso))
{
    Console.WriteLine($"A forma extensa do número {numero} é {extenso}");
}
else
{
    Console.WriteLine("Número inválido");
}