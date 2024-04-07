//using LINQandAPIs_STUDIES.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQandAPIs_STUDIES.Filters
//{
//    internal class ProductsFilter
//    {
//        List<Prroduto> produtos = new List<Prroduto>
//        {
//            new Prroduto { Nome = "Laptop", Preco = 1200 },
//            new Prroduto { Nome = "Smartphone", Preco = 800 },
//            new Prroduto { Nome = "Tablet", Preco = 500 },
//            new Prroduto { Nome = "Câmera", Preco = 300 }
//        };
//        ProductsFilter.PrecoMedioDosProdutos(produtos);
//        public static void PrecoMedioDosProdutos(List<Prroduto> produtos)
//        {
//            var precoMedio = produtos.Average(x => x.Preco);
//            Console.WriteLine(precoMedio);
//        }
//    }
//}
