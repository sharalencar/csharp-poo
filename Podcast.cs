using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_poo
{
    public class Podcast
    {
        private List<Episodio> episodios = new List<Episodio>();
        public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }
        public string Nome { get; }
        public string Host { get; }
        public int TotalEpisodios => episodios.Count();
        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }
        public void ExibirDetalhes()
        {
          Console.WriteLine($"{Nome}, apresentado por {Host}");
          foreach (Episodio episodio in episodios.OrderBy(e => e.NumeroEpisodio))
          {
            Console.WriteLine(episodio.Resumo);
          }
          Console.WriteLine($"Total de episódios disponíveis: {TotalEpisodios}");
        }
    }
}