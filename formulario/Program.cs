/*
preenchimento de formulário simples
dicionario com as informações organizadas
nome idade peso altura 
conseguir chamar a informação por nome
*/

internal class Program

{
    private static void Main()
    {
        var usuarios = new Dictionary<string, string>();
        Console.WriteLine("Insira seu nome: ");
        string nome = Console.ReadLine();
        usuarios.Add("nome", nome);
        foreach (var i in usuarios)
        {
            Console.WriteLine($"nome: {i.Value}");
        }
    }
}