class Paciente
{
    public string? Nome { get; private set; }
    public int Idade { get; private set; }
    public string? Email { get; private set; }
    public double Altura { get; private set; }
    public double Peso { get; set; }
    public string TipoSangue { get; set; }
    public string Telefone { get; set; }

    private static readonly string[] TiposSanguineos =
    { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };

    public void PreencherDados()
    {
        Nome = PreencherNome();
        Idade = PreencherIdade();
        Email = PreencherEmail();
        Telefone = PreencherTelefone();
        Altura = PreencherAltura();
        Peso = PreencherPeso();
        TipoSangue = PreencherTipoSanguineo();

    }
    public void MostrarDados()
    {
        Console.WriteLine("= = = = = = = = = = = = = = = = = = =");
        Console.WriteLine("           Dados do Paciente         ");
        Console.WriteLine($"Nome            : {Nome}");
        Console.WriteLine($"Idade           : {Idade}");
        Console.WriteLine($"Email           : {Email}");
        Console.WriteLine($"Telefone        : {Telefone}");
        Console.WriteLine($"Altura          : {Altura} metros");
        Console.WriteLine($"Peso            : {Peso} kg");
        Console.WriteLine($"Tipo Sanguíneo  : {TipoSangue}");
        Console.WriteLine("= = = = = = = = = = = = = = = = = = =");
    }

    private string PreencherNome()
    {
        while(true)
        {
            Console.WriteLine("Insira seu nome");
            try
            {
                string? input = Console.ReadLine();

                if (input == null)
                throw new NullReferenceException("Input retornou nulo");

                if (input.Trim().Length == 0)
                throw new ArgumentException("Nome não pode ser vazio");

                if (input.Trim().Length < 2)
                throw new ArgumentException("Nome deve conter ao menos 2 letras");

                return input;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }

    private int PreencherIdade()
    {
        while(true)
        {
            Console.WriteLine("Insira sua data de nascimento:");
            try
            {
                Console.Write("Dia: ");
                string? diaInput = Console.ReadLine();
                Console.Write("Mês: ");
                string? mesInput = Console.ReadLine();
                Console.Write("Ano: ");
                string? anoInput = Console.ReadLine();

                if (diaInput == null || mesInput == null || anoInput == null)
                    throw new NullReferenceException("Input retornou nulo");

                int dia = Convert.ToInt32(diaInput);
                int mes = Convert.ToInt32(mesInput);
                int ano = Convert.ToInt32(anoInput);

                if (dia <= 0 || dia > 31 || mes <= 0 || mes > 12 || ano <= 0 || ano > DateTime.Today.Year)
                    throw new ArgumentOutOfRangeException("Data de nascimento inválida");

                var birthdate = new DateTime(ano, mes, dia);
                var today = DateTime.Today;
                int idade = today.Year - birthdate.Year;

                if (birthdate.Date > today.AddYears(-idade))
                    idade--;

                if (idade < 0)
                    throw new ArgumentOutOfRangeException("Data de nascimento no futuro");

                return idade;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }

    private string PreencherEmail()
    {
        while(true)
        {
            Console.WriteLine("Insira seu email");
            try
            {
                string? input = Console.ReadLine();

                if (input == null)
                throw new NullReferenceException("Input retornou nulo");

                if (input.Trim().Length == 0)
                throw new ArgumentException("Email não pode ser vazio");

                if (!input.Contains("@") || !input.Contains("."))
                throw new ArgumentException("Email deve conter '@' e '.'");

                return input.Trim();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }

    private string PreencherTelefone()
    {
        while(true)
        {
            Console.WriteLine("Insira seu telefone (apenas números):");
            try
            {
                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                    throw new NullReferenceException("Telefone não pode ser vazio");
                long.Parse(input);

                if (input.Length < 8 || input.Length > 9)
                    throw new ArgumentOutOfRangeException("Telefone deve conter entre 8 e 9 dígitos");
                return input;

            }catch (NullReferenceException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
             }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }

    private double PreencherAltura()
    {
        while(true)
        {
            Console.WriteLine("Insira sua altura em metros (ex: 1.75):");
            try
            {
                string? input = Console.ReadLine();

                if (input == null)
                    throw new NullReferenceException("Input retornou nulo");

                double altura = Convert.ToDouble(input);

                if (altura <= 0 || altura > 2.60)
                    throw new ArgumentOutOfRangeException("Altura deve ser entre 0 e 2.60 metros");

                return altura;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }

    private string PreencherTipoSanguineo()
    {
        while(true)
        {
            Console.WriteLine("Insira seu tipo sanguíneo (A+, A-, B+, B-, AB+, AB-, O+, O-):");
            try
            {
                string? input = Console.ReadLine()?.Trim().ToUpper();

                if (input == null)
                    throw new NullReferenceException("Input retornou nulo");

                if (!TiposSanguineos.Contains(input))
                    throw new ArgumentException("Tipo sanguíneo inválido. Escolha entre A+, A-, B+, B-, AB+, AB-, O+ ou O-.");

                return input;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }

    private double PreencherPeso()
    {
        while(true)
        {
            Console.WriteLine("Insira seu peso em kg (ex: 70.5):");
            try
            {
                string? input = Console.ReadLine();

                if (input == null)
                    throw new NullReferenceException("Input retornou nulo");

                double peso = Convert.ToDouble(input);

                if (peso <= 0 || peso > 500)
                    throw new ArgumentOutOfRangeException("Peso deve ser entre 0 e 500 kg");

                return peso;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }

}