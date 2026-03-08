class Playlist
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void RemoverMusica(Musica musica)
    {
        musicas.Remove(musica);
    }

    public void ExibirPlaylist()
    {
        Console.WriteLine($"Playlist: {Nome}");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"- {musica.Nome} - {musica.Artista.Nome}");
        }
    }
}