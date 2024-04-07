//using LINQandAPIs_STUDIES.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQandAPIs_STUDIES.Filters
//{
//    internal class BookFilter
//    {
//        try
//        {
//            List<Livro> livros = new List<Livro>
//                {
//                    new Livro { Titulo = "Aprendendo LINQ", Lancamento = 2005 },
//                    new Livro { Titulo = "Programação em C#", Lancamento = 2010 },
//                    new Livro { Titulo = "Algoritmos e Estruturas de Dados", Lancamento = 1998 },
//                    new Livro { Titulo = "Introdução à Inteligência Artificial", Lancamento = 2021 },
//                    new Livro { Titulo = "Design", Lancamento = 2005 }

//                };
//                BookFilter.FilterByYear(livros);
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine(e.Message);
//        }
//public static void FilterByYear(List<Livro> livros)
//        {
//            var livrosDoAno = livros.Where(livro => livro.Lancamento >= 2010).OrderBy(l => l.Titulo).Select(l => l.Titulo);
//            foreach(var livro in livrosDoAno)
//            {
//                Console.WriteLine(livro);
//            }
//        }
//    }
//}
