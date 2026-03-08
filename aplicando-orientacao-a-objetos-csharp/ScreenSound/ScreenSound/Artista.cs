class Artista
{
    public string Nome { get; set; }

    public int Idade { get; set; }

    public int AnoDeFormacao { get; set; }

    public string Biografia { get; set; }

    public List<Album> Albums { get; set; } = new List<Album>();

    public void ExibirBiografia()
    {
        Console.WriteLine($"Biografia de {Nome}:");
        Console.WriteLine(Biografia);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia de {Nome}:");
        foreach (Album album in Albums)
        {
            Console.WriteLine($"- {album.Nome} ({album.DuracaoTotal})");
        }
    }

    public void AdicionarAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void ExibirDetalhesDoArtista()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Ano de Formação: {AnoDeFormacao}");
        Console.WriteLine($"Biografia: {Biografia}");
    }

}