using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d1 = new Dictionary<string, int>();
            d1.Add("123", 1);
            d1.Add("431", 2);

            var getVauleByKey123 = d1["123"];//return 1

            DictionaryTest<string, int> dic = new DictionaryTest<string, int>();
            dic.Add("123", 1);
            dic.Add("431", 2);

            var dictionaryTest_getVauleByKey123 = dic["123"];


            Console.Write("Break.");
        }
    }
}
