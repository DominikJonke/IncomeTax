using System;

namespace IncomeTax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t Tax Income Calculator");
            Console.WriteLine();
            Console.WriteLine($"You must pay {Tax.QueryTax()} Euro");
        }
    }
}
