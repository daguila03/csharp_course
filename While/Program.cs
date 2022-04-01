using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            string[] friends = new string[7] {
                "Antonio",
                "Rosario",
                "Maria",
                "Taco",
                null,
                null,
                null
            };

            int index = 0;
            while (index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }

            bool run = false;
            do
            {
                Console.WriteLine("Entro al menos una vez");
            } while (run);

        }
    }
}
