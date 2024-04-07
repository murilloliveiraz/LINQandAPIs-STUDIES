using LINQandAPIs_STUDIES.Filters;
using LINQandAPIs_STUDIES.Models;
using System.Text.Json;

try
{
    using (HttpClient client = new HttpClient())
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Music>>(resposta); ;
        var musicasPreferidas = new MusicasFavoritas("Murillo");
        musicasPreferidas.AdicionarMusica(musicas[1]);
        musicasPreferidas.AdicionarMusica(musicas[3]);
        musicasPreferidas.AdicionarMusica(musicas[8]);
        musicasPreferidas.AdicionarMusica(musicas[11]);
        musicasPreferidas.AdicionarMusica(musicas[1467]);

        LINQFilter.GetByKey(musicas, "C#");
    } 
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}