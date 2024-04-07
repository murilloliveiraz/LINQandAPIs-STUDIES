using LINQandAPIs_STUDIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQandAPIs_STUDIES.Filters
{
    internal class LINQFilter
    {
        public static void FiltrarPorGeneroMusical(List<Music> musicas)
        {
            var todosOsGeneros = musicas.Select(musica => musica.Genero).Distinct().ToList();
            foreach (var genero in todosOsGeneros)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Music> musicas, string genero)
        {
            var artistas = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in artistas)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Music> musicas, string artista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
            foreach (var music in musicasDoArtista)
            {
                Console.WriteLine($"- {music.Nome}");
            }
        }

        public static void GetByKey(List<Music> musicas, string key)
        {
            var musicasComANota = musicas.Where(m => m.Keys[m.Key].Equals(key)).ToList();
            foreach (var music in musicasComANota)
            { music.Details(); }
        }
    }
}
