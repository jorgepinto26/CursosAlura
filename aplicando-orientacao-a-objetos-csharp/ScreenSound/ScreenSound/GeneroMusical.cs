class GeneroMusical
{
    public List<Musica> MusicaAssociadas { get; set; } = new List<Musica>();

    public List<Artista> ArtistasAssociados { get; set; } = new List<Artista>();

    public List<Album> AlbunsAssociados { get; set; } = new List<Album>();

    public string Nome { get; set; }

    public string Descricao { get; set; }


    public void AdicionarMusica(Musica musica)
    {
        MusicaAssociadas.Add(musica);
    }

    public void AdicionarArtista(Artista artista)
    {
        ArtistasAssociados.Add(artista);
    }

    public void AdicionarAlbum(Album album)
    {
        AlbunsAssociados.Add(album);
    }

    public void ExibirMusicasAssociadas()
    {
        Console.WriteLine($"Músicas associadas ao gênero {Nome}:");
        foreach (var musica in MusicaAssociadas)
        {
            Console.WriteLine($"- {musica.Nome} por {musica.Artista}");
        }
    }

    public void ExibirArtistasAssociados()
    {
        Console.WriteLine($"Artistas associados ao gênero {Nome}:");
        foreach (var artista in ArtistasAssociados)
        {
            Console.WriteLine($"- {artista.Nome}");
        }
    }

    public void ExibirAlbunsAssociados()
    {
        Console.WriteLine($"Álbuns associados ao gênero {Nome}:");
        foreach (var album in AlbunsAssociados)
        {
            Console.WriteLine($"- {album.Nome}");
        }
    }

    public void ExibirInformacoesDoGenero()
    {
        Console.WriteLine($"Gênero Musical: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        ExibirMusicasAssociadas();
        ExibirArtistasAssociados();
        ExibirAlbunsAssociados();
    }

}