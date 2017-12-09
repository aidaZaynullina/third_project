using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket1 = new Basket();
            using (var basketReader = new StreamReader(new FileStream("Fruct_Basket.txt", FileMode.OpenOrCreate)))
            {
                var basket = basketReader.ReadLine();
                var deserialized_basket = JsonConvert.DeserializeObject<Basket>(basket);
                Console.WriteLine(JsonConvert.DeserializeObject<Basket>(basket) + "\nPRESS ANY KEY TO EXIT...");
                Console.ReadKey();
            }
        }
        public class Basket
        {
            public string Apple { get; set; } 
            public string Ananasik { get; set; } 
            public string Persic { get; set; } 
            public string Apelsinсhic { get; set; } 
        }
    }
}
