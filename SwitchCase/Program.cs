using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            switch (op)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("mayor");
                    break;
                default:
                    Console.WriteLine("no");
                    break;
            }
        }
    }
}
