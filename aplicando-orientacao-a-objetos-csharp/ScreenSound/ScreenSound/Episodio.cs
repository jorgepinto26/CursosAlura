class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"Episódio {Ordem}. Título: {Titulo}. Duração: {Duracao} min. Convidados: {string.Join(", ", convidados)}";
    
    public void AdicionarConvidados(string nomeDoConvidado)
    {
        convidados.Add(nomeDoConvidado);
    }

    public void ExibirConvidados()
    {
        foreach(var convidado in convidados)
        {
            Console.WriteLine(convidado);
        }
    }
}