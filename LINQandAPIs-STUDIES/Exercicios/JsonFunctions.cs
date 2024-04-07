using LINQandAPIs_STUDIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LINQandAPIs_STUDIES.Exercicios
{
    internal class JsonFunctions
    {
        //ex 1
        public void SerializePessoa()
        {
            Pessoa pessoa = new Pessoa();
            Console.Write("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o e-mail: ");
            pessoa.Email = Console.ReadLine();

            string json = JsonSerializer.Serialize(pessoa);
            string path = $"dados-pessoa-{pessoa.Nome}.json";
            File.WriteAllText(path, json);
            Console.WriteLine($"Arquivo json criado com sucesso em {Path.GetFullPath(path)}");
        }

        public void DeserializePessoa(string url)
        {
            string filename = url;
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                Console.WriteLine(json);
                Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(json)!;
                Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade}, {pessoa.Email}");
            }
        }

        public void SerializeListOfPeople()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            while (true)
            {
                Console.WriteLine("Deseja adicionar uma pessoa?");
                string resp = Console.ReadLine();
                if (resp == "nao")
                {
                    break;
                }

                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Idade:");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Emal:");
                string email = Console.ReadLine();
                Pessoa pessoa = new Pessoa() { Nome = nome, Email = email, Idade = idade };
                pessoas.Add(pessoa);
            }
            string json = JsonSerializer.Serialize(pessoas);
            string path = $"dados-pessoas.json";
            File.WriteAllText(path, json);
            Console.WriteLine($"Arquivo json criado com sucesso em {Path.GetFullPath(path)}");
        }

        public void DisserializeAndCreateAList(string filePath)
        {
            string path = filePath;
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);
                List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);
                foreach (var pessoa in pessoas)
                {
                    Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade}, {pessoa.Email}");
                }
            }
        }

        public void DisserializeByAge()
        {
            string path = "dados-pessoas.json";
            if (File.Exists(path))
            {
                Console.WriteLine("Informe uma Idade");
                int idade = int.Parse(Console.ReadLine());
                string jsonString = File.ReadAllText(path);
                List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);
                var PessoasCOmAIdade = pessoas.Where(p => p.Idade.Equals(idade)).Select(p => p.Nome).ToList();
                if (PessoasCOmAIdade.Count > 0)
                {
                    foreach (var pessoa in PessoasCOmAIdade)
                    {
                        Console.WriteLine(pessoa);
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma pessoa com a idade especificada na lista");
                }
            }
        }
    }
}
