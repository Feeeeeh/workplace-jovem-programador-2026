using System.Diagnostics.Contracts;

class Aluno
{
    public string Nome {get; private set; }
    public double[] Notas {get; private set; } = new double[4];
    public double Media {get; private set;}

    public void DefinirNome(string nome)
    {
        Nome = nome;
    }

    public void DefinirNota(int i, double nota)
    {
        Notas[i] = nota;
    }

    public void DefinirMedia(double media)
    {
        Media = media;
    }
}
