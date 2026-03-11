Console.WriteLine(@"Escolha seu Pokémon inicial!
[1] Charmander 
[2] Bulbasauro
[3] Squirtle
            ");
int escolha = Convert.ToInt32(Console.ReadLine());

switch (escolha)
{
    case 1:
    Console.WriteLine("Você escolheu Charmander!");
    break;

    case 2:
    Console.WriteLine("Você escolheu Bulbasauro!");
    break;

    case 3:
    Console.WriteLine("Você escolheu Squirtle!");
    break;

    case 4:
    Console.WriteLine("Você descobriu a escolha secreta e conseguiu um Pikachu!");
    break;

    default:
    Console.WriteLine("Escolha inválida, vai ficar sem Pokémon.");
    break;
}