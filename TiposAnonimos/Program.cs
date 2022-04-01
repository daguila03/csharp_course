using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var hector = new
            {
                Name = "Hector",
                Country = "Mexico"
            };

            Console.WriteLine(hector.Name);

            var beers = new[]
            {
                new { Name = "Red"},
                new { Name = "London"}
            };

            foreach(var b in beers)
            {
                Console.WriteLine(b.Name);
            }
        }
    }
}
