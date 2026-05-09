List<Aluno> alunos = new List<Aluno>();


while (true)
{
    Console.WriteLine("\n1 - Adicionar aluno");
    Console.WriteLine("2- Listar alunos");
    Console.WriteLine("3 - Sair");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            if (alunos.Count >= 4)
            {
                Console.WriteLine("Limite de alunos atingido.");
                continue;
            }

            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.DefinirNome(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Nota {i + 1}: ");
                aluno.DefinirNota(i,double.Parse(Console.ReadLine()));
            }

            Calculadora.CalcularMedia(aluno);

            alunos.Add(aluno);

            Console.WriteLine("Aluno Adicionado");
            continue;
        case 2:
            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine($"\nNome: {alunos[i].Nome,-15}Media: {alunos[i].Media}");
            }
            continue;
        case 3:
            Environment.Exit(0);
            break;
    }
}
