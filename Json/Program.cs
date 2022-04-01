using System;
using System.Text.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Pikantus",
                Brand = "Erdinger"
            };

            // string json = "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}";
            string json = JsonSerializer.Serialize(myBeer);
            //Console.WriteLine(json);
            Beer beer = JsonSerializer.Deserialize<Beer>(json);
        }


        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }
        }
    }
}
