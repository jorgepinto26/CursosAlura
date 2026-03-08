class AvaliacaoMusical
{
    public double Nota { get; set; }

    public Musica Musica { get; set; }

    public Dictionary<string, List<double>> Notas { get; set; } = new Dictionary<string, List<double>>();

    public void ExibirAvaliacaoDeUmaMusica(Musica musica, double nota)
    {
        Console.WriteLine($"A {musica} ");
    }
}