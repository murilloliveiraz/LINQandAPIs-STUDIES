using LINQandAPIs_STUDIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQandAPIs_STUDIES.Filters
{
    internal class LINQFilterNames
    {
        public static void FiltrarPorNome(List<Music> musicas)
        {
            var nomes = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var nome in nomes)
            {
                Console.WriteLine($"- {nome}");
            }
        }
    }
}
