using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_poo
{
    public class Album
    {
        private List<Musica> musicas = new List<Musica>();
        public Album(string nome)
        {
            Nome = nome;   
        }
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
        public void ExibirMusicasDoAlbum()
        {   
            Console.WriteLine($"Lista de músicas do álbum {Nome}, {DuracaoTotal}s:\n");
            foreach(var musica in musicas)
            {
                Console.WriteLine($"Título: {musica.Nome}");
            }
        }
    }
}