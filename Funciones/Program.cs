using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            Show();
            Sum(a, b);
            int m = Mul(a, b);
            Console.WriteLine(m);


            static int Mul(int num1, int num2)
            {
                int num3 = num1 * num2;
                return num3;
            }

            
            static void Sum(int num1, int num2)
            {
                int num3 = num1 + num2;
                //Console.WriteLine(num3);
            }


            static void Show()
            {
                Console.WriteLine("HOLA, soy un texto desde la funcion");
            }
        }
    }
}
