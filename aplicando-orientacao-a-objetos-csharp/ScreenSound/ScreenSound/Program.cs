Episodio ep1 = new(1,"Técnicas de omeletia", 45);
ep1.AdicionarConvidados("Maria merendeira");
ep1.AdicionarConvidados("Marcelo dos ovo");

Episodio ep3 = new(3, "Técnicas de reconhecimento da casca do ovo", 69);
ep3.AdicionarConvidados("Casconcio");
ep3.AdicionarConvidados("Casquito");

Episodio ep2 = new(2, "Técnicas de clara em neve", 42);
ep2.AdicionarConvidados("Batedeira Martins");
ep2.AdicionarConvidados("Fue José");

Episodio ep4 = new(4, "Técnicas de artilharia oval", 48);
ep4.AdicionarConvidados("Ovo baroni");
ep4.AdicionarConvidados("Ovada da Silva");

Podcast podcast = new("Podcast do Ovo", "Seu Zé");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.AdicionarEpisodios(ep3);
podcast.AdicionarEpisodios(ep4);

podcast.ExibirDetalhes();





