class ReprodutorMusical
{
    public Musica Musica { get; set; }
    public void Reproduzir()
    {
        if (Musica != null)
        {
            Console.WriteLine($"Reproduzindo: {Musica.Nome} - {Musica.Artista.Nome}");
        }
        else
        {
            Console.WriteLine("Nenhuma música selecionada para reprodução.");
        }
    }

    public void Pausar()
    {
        if (Musica != null)
        {
            Console.WriteLine($"Pausando: {Musica.Nome} - {Musica.Artista.Nome}");
        }
        else
        {
            Console.WriteLine("Nenhuma música selecionada para pausar.");
        }
    }

    public void Avancar()
    {
        if (Musica != null)
        {
            Console.WriteLine($"Avançando: {Musica.Nome} - {Musica.Artista.Nome}");
        }
        else
        {
            Console.WriteLine("Nenhuma música selecionada para avançar.");
        }
    }

    public void Retroceder()
    {
        if (Musica != null)
        {
            Console.WriteLine($"Retrocedendo: {Musica.Nome} - {Musica.Artista.Nome}");
        }
        else
        {
            Console.WriteLine("Nenhuma música selecionada para retroceder.");
        }
    }

    public void ControlarVolume(int nivel)
    {
        Console.WriteLine($"Ajustando volume para: {nivel}");
    }
}