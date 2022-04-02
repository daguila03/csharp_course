using System;
using System.IO;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Daniel\Desktop\pollo.txt");
                Console.WriteLine(content);

                string content2 = File.ReadAllText(@"C:\Users\Daniel\Desktop\pollo2.txt");
                Console.WriteLine(content2);
                throw new Exception("Ocurrio algo raro");
            } catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("el archivo no existe");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("Finally");
            }

        }
    }
}
