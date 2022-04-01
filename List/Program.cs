using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();


            numbers.Add(5);
            numbers.Add(2);

            Console.WriteLine(numbers.Count);

            List<int> numbers2 = new List<int>()
            {
                1,5,10,4,78,17
            };
            Console.WriteLine(numbers2.Count);

            numbers2.Clear();
            Console.WriteLine(numbers2.Count);

            List<string> countries = new List<string>()
            {
                "Arg", "Mx"
            };
            Console.WriteLine(countries.Count);

        }
    }
}
