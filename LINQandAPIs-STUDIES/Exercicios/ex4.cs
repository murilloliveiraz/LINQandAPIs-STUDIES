//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQandAPIs_STUDIES.Filters
//{
//    internal class NumberFilter
//    {
//        public static void NumerosUnicos(List<int> numbers)
//        {
//            List<int> numbers = new List<int>() { 1, 6, 7, 8, 9, 1, 4, 5, 7, 2 };
//            NumberFilter.NumerosUnicos(numbers);
//            var numeros = numbers.Select(x => x).Distinct().ToList();
//            foreach (var n in numeros)
//            {
//                Console.Write($"{n}, ");
//            }
//        }
//    }
//}
