class Filme
{
    public Filme(string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public List<string> Elenco { get; set; }

    public void AdicionarElenco(string nome)
    {
        Elenco.Add(nome);
    }

    public void ExibirElenco()
    {
        Console.WriteLine("Elenco: ");
        foreach (var elenco in Elenco)
        {
            Console.WriteLine(elenco);
        }
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Título: {Titulo}. Duração: {Duracao} min. Elenco: {string.Join(", ", Elenco)}");
    }
}