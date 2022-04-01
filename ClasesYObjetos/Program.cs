using System;

namespace ClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100, DateTime.Now);
            Sale sale2 = new Sale(200, DateTime.Now);

            string info = sale1.GetInfo(), info2 = sale2.GetInfo();
            Console.WriteLine(info);
            Console.WriteLine(info2);
        }
    }

    class Sale
    {
        int total;
        DateTime date;

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }
        public void Show()
        {
            Console.WriteLine("Soy una venta");
        }
    }
}
