class Calculadora
{
    public static void CalcularMedia(Aluno aluno)
    {
        double soma = 0;

        for (int i = 0; i < 4; i++)
        {
            soma += aluno.Notas[i];
        }
        double media = soma / 4;
        aluno.DefinirMedia(media);
    }
}