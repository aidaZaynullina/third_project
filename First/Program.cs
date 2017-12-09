using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        { 
                var basket1 = new Fruct_Basket();
                var basket1_serialized = JsonConvert.SerializeObject(basket1);
                using (var basketWriter = new StreamWriter(new FileStream("Fruct_Basket.txt", FileMode.OpenOrCreate)))
                {
                    basketWriter.WriteLine(basket1_serialized);
                }
        }

    }
        public class Fruct_Basket
        {
            public string Apple { get; set; } = "Solncem napoyonoe";
            public string Ananasik { get; set; } = "Pod uzhnym solncem vyros ya";
            public string Persic { get; set; } = "Chudesniy, dlya zdoroviya polezniy";
            public string Apelsinсhic { get; set; } = "Sochniy vitaminchik";
        }
    }
