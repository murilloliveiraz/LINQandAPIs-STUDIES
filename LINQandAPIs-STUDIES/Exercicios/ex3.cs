//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;

//namespace LINQandAPIs_STUDIES.Models
//{
//    internal class Country
//    {
//        using LINQandAPIs_STUDIES.Models;
//        using System.Text.Json;

//        try
//        {
//            using (HttpClient client = new HttpClient())
//            {
//                string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
//            var filmes = JsonSerializer.Deserialize<List<Country>>(resposta)!;
//            filmes[3].Details();
//        } 
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine(e.Message);
//        }
//        [JsonPropertyName("nome")]
//        public string? Nome { get; set; }
//        [JsonPropertyName("capital")]
//        public string? Capital { get; set; }
//        [JsonPropertyName("idioma")]
//        public string? Idioma { get; set; }

//        public void Details()
//        {
//            Console.WriteLine($"No(a) {Nome}, a capital é {Capital} e o idioma oficial é o {Idioma}");
//        }
//    }
//}
