using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                45,5,89,32,12,
            };

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            List<People> students = new List<People>()
            {
                new People() { Name = "Hector", Country = "Mexico"},
                new People() { Name = "Roberto", Country = "Argentina"},
                new People() { Name = "Ana", Country = "Estados Unidos"},
            };
            Show(students);
            students.RemoveAt(0);
            Show(students);
            
        }

        static void Show(List<People> students)
        {
            Console.WriteLine("***Personas***");
            foreach (var student in students)
            {
                Console.WriteLine(student.Name + " - " + student.Country);
            }
        }
    }

    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
