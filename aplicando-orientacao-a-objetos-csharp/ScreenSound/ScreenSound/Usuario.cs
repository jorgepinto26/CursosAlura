class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Plano { get; set; }

    public List<Musica> HistoricoDeReproducao { get; set; } = new List<Musica>();

    public List<Playlist> PlaylistsCriadas { get; set; } = new List<Playlist>();

    public void ExibirInformacoesDoUsuario()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Plano: {Plano}");
    }

    public void AdicionarMusicaAoHistorico(Musica musica)
    {
        HistoricoDeReproducao.Add(musica);
    }

    public void AdicioanrPlaylist(Playlist playlist)
    {
        PlaylistsCriadas.Add(playlist);
    }

    public void ExibirHistoricoDeReproducao()
    {
        Console.WriteLine($"Histórico de reprodução de {Nome}:");
        foreach (var musica in HistoricoDeReproducao)
        {
            Console.WriteLine($"- {musica.Nome} por {musica.Artista.Nome}");
        }
    }

    public void ExibirPlaylistsCriadas()
    {
        Console.WriteLine($"Playlists criadas por {Nome}:");
        foreach (var playlist in PlaylistsCriadas)
        {
            Console.WriteLine($"- {playlist.Nome}");
        }
    }   
}