Paciente paciente = new Paciente();
bool formulario_preenchido = false;
bool run = true;

void Continuar()
{
    Console.WriteLine("\n\nPressione Enter para continuar");
    Console.ReadLine();
}

while (run)
{
    Console.Clear();
    Console.WriteLine("\n - - Clínica SENAC - - \n");
    Console.WriteLine("1 - Cadastrar usuario");
    Console.WriteLine("2 - Listar usuarios");
    Console.WriteLine("3 - Sair");

    Console.Write("Escolha uma opção:\n");

    try
    {
        string? input = Console.ReadLine();
        int option = Convert.ToInt32(input);

        switch (option)
        {
            case 1:
                paciente.PreencherDados();
                formulario_preenchido = true;
                Console.WriteLine("Paciente cadastrado com sucesso!");
                Continuar();
                break;
            case 2:
                if (!formulario_preenchido)
                {
                    Console.WriteLine("Nenhum paciente cadastrado.");
                }
                else
                {
                    paciente.MostrarDados();
                }
                Continuar();
                break;
            case 3:                
                Console.WriteLine("Saindo...");
                run = false;
                break;
            default:
                Console.WriteLine("Opção inválida. Escolha entre 1 e 3.");
                Continuar();
                break;
        }
    }catch (FormatException)
    {
        Console.WriteLine("Entrada inválida. Por favor, insira um número.");
        Continuar();
    }
    catch (NullReferenceException e)
    {
        Console.WriteLine($"Erro: {e.Message}");
        Continuar();
    }
}