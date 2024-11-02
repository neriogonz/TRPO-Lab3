// See https://aka.ms/new-console-template for more information
using TrpoLabs.Core;

namespace TrpoLabs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Console.WriteLine($"El resultado de 2 + 3 es: {result}");
        }
    }
}
