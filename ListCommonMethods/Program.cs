using System;
using System.Collections.Generic;

namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                8,88,4,5,6,7,8,9,10
            };

            Show(numbers);
            // Inserta un elemento en la posicion 0
            numbers.Insert(0, 1);
            Show(numbers);
            // Inserta un elemento a la lista
            numbers.Add(55);
            Show(numbers);
            // Si existe el elemento en la lista
            if(numbers.Contains(10))
                Console.WriteLine("Existe");
            else
                Console.WriteLine("No existe");

            // Posicion del elemento en la lista
            int pos = numbers.IndexOf(6);
            Console.WriteLine(pos);

            // Ordena los elementos de la lista de menor a mayor
            numbers.Sort();
            Show(numbers);

            //Inserta una lista nueva
            numbers.AddRange(new List<int>()
            {
                200,300,400
            });
            Show(numbers);
        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("**Numeros**");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
