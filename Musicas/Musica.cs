using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace csharp_poo
{
    public class Musica
    {
        public Musica(string nome, Banda artista)
        {   
            Nome = nome;
            Artista = artista;
        }
        
        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string Descricao => $"Música {Nome} da banda {Artista.Nome}.";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao} segundos");
            if (Disponivel) 
            {
                Console.WriteLine("Música displonível no plano atual");
            } else
            {
                Console.WriteLine("Adquira o Plano Plus");
            }
        }
    }
}