using LINQandAPIs_STUDIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LINQandAPIs_STUDIES.Models
{
    internal class MusicasFavoritas
    {
        public string Nome { get; set; }
        public List<Music> Musicas { get;}

        public MusicasFavoritas(string nome)
        {
            Nome = nome;
            Musicas = new List<Music>();
        }

        public void AdicionarMusica(Music music)
        {
            Musicas.Add(music);
        }

        public void exibirMusicas()
        {
            Console.WriteLine($"Essas sao as musicas Favoritas -> {Nome}");
            foreach (Music music in Musicas)
            {
                music.Details();
            }
        }

       public void GerarArquivo()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = Musicas
            });
            string path = $"musicas-favoritas-{Nome}.json";
            File.WriteAllText(path, json);
            Console.WriteLine($"Arquivo json criado com sucesso em {Path.GetFullPath(path)}");

        }

        public void GetByKey(string key)
        {
            var musicasComANota = Musicas.Where(m => m.Keys[m.Key].Equals(key)).ToList();
            foreach(var music in musicasComANota)
            { music.Details(); }
        }
    }
}

//string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
//var musicas = JsonSerializer.Deserialize<List<Music>>(resposta); ;
//var musicasPreferidas = new MusicasFavoritas("Murillo");
//musicasPreferidas.AdicionarMusica(musicas[1]);
//musicasPreferidas.AdicionarMusica(musicas[3]);
//musicasPreferidas.AdicionarMusica(musicas[8]);
//musicasPreferidas.AdicionarMusica(musicas[11]);
//musicasPreferidas.AdicionarMusica(musicas[1467]);

//musicasPreferidas.exibirMusicas();
//musicasPreferidas.GerarArquivo();