﻿using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>(10);
            numbers.Add(10);
            numbers.Add(5);

            MyList<string> strings = new MyList<string>(10);
            strings.Add("Daniel");

            MyList<People> peoples = new MyList<People>(5);
            peoples.Add(new People() { Name = "Rosario", Country = "Mx" });
            peoples.Add(new People() { Name = "Daniel", Country = "Mx" });


            Console.WriteLine(numbers.GetString());
            Console.WriteLine(strings.GetString());
            Console.WriteLine(peoples.GetString());



            Console.WriteLine(numbers.GetElement(11));
            Console.WriteLine(strings.GetElement(11));
        }
    }

    public class People
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name}, Pais: {Country}";
        }
    }
    public class MyList<T>
    {
        private T[] _elements;
        private int _index = 0;

        public MyList(int n)
        {
            _elements = new T[n];
        }

        public void Add(T e)
        {
            if(_index < _elements.Length)
            {
                _elements[_index] = e;
                _index++;
            }
        }

        public T GetElement(int i)
        {
            if(i <= _index && i >= 0)
            {
                return _elements[i];
            }

            return default(T);
        }

        public string GetString()
        {
            int i = 0;
            string result = "";
            while (i < _index)
            {
                result += _elements[i].ToString() + "|";
                i++;
            }

            return result;
        }
    }
}
