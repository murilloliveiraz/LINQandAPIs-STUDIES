//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;

//namespace LINQandAPIs_STUDIES.Models
//{
//    internal class Movie
//    {
//        using LINQandAPIs_STUDIES.Models;
//        using System.Text.Json;

//        try
//        {
//            using (HttpClient client = new HttpClient())
//            {
//                string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
//            var filmes = JsonSerializer.Deserialize<List<Movie>>(resposta)!;
//            filmes[0].Details();
//        } 
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine(e.Message);
//        }

//        [JsonPropertyName("title")]
//        public string? Nome { get; set; }
//        [JsonPropertyName("year")]
//        public string? Ano { get; set; }
//        [JsonPropertyName("image")]
//        public string? Capa { get; set; }

//        public void Details()
//        {
//            Console.WriteLine($"Nome {Nome}");
//            Console.WriteLine($"Ano de Lançamento {Ano}");
//            Console.WriteLine($"Capa  {Capa}");
//        }
//    }
//}
