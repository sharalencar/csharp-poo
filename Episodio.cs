using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_poo
{
    public class Episodio
    {
        private List<string> convidados = new List<string>();
        public Episodio(int numEpisodio, string titulo, int duracao)
        {
            NumeroEpisodio = numEpisodio;
            Titulo = titulo;
            Duracao = duracao;
        }
        public int NumeroEpisodio { get; }
        public string Titulo { get; }
        public int Duracao { get; }
        public string Resumo => $"Episódio #{NumeroEpisodio} - {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
        public void AdicionarConvidados(string convidado)
        {
            convidados.Add(convidado);
        }
    }
}