class Musica
{
    public string Nome { get; set; }
    public Banda Artista { get; }
    public Musica(Banda artista, string musica)
    {
        Artista = artista;
        Nome = musica;
    }

    public GeneroMusical Genero { get; set; }
    public int Duracao { get; set; }    
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista.Nome}";
        
       


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Indisponível. Disponível no plano Plus+.");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}