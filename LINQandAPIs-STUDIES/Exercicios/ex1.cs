//using LINQandAPIs_STUDIES.Models;
//using System.Text.Json;

//try
//{
//    using (HttpClient client = new HttpClient())
//    {
//        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
//        var musicas = JsonSerializer.Deserialize<List<Music>>(resposta)!;
//        musicas[0].Details();
//    } 
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}