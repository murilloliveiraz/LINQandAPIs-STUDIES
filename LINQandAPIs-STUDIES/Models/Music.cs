using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LINQandAPIs_STUDIES.Models
{
    internal class Music
    {
        [JsonPropertyName("key")]
        public int Key { get; set; }
        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        
        [JsonPropertyName("duration_ms")]
        public int? Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        public string[] Keys = ["C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"];
        public void Details()
        {
            Console.WriteLine($"Artista {Artista}");
            Console.WriteLine($"Nota {Keys[Key]}");
            Console.WriteLine($"Musica {Nome}");
            Console.WriteLine($"Duracao {Duracao / 1000}");
            Console.WriteLine($"Genero {Genero}");
        }
    }
}
