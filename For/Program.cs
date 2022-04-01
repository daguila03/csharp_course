using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7] {
                "Antonio",
                "Rosario",
                "Maria",
                "Taco",
                null,
                null,
                null
            };

            for (int index = 0;  index < friends.Length; index++)
            {
                Console.WriteLine(friends[index]);
            }
        }
    }
}