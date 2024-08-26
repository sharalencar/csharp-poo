using csharp_poo;

Podcast hypezilla = new Podcast("Hypezilla", "Pri Ganiko");

Episodio ep1 = new Episodio(1, "Frieren e a Jornada para o Além", 120);
Episodio ep2 = new Episodio(2, "Animes da temporada de verão", 143);
ep1.AdicionarConvidados("Cakes");
ep1.AdicionarConvidados("Load Comiks");
ep2.AdicionarConvidados("Kou");

hypezilla.AdicionarEpisodio(ep1);
hypezilla.AdicionarEpisodio(ep2);
hypezilla.ExibirDetalhes();
