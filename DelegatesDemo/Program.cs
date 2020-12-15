using System;
using DelegatesLibrary;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new TotalCostCalculator(100);
            var totalCost = calculator.CalculateTotalCost(price => price * 0.23m, ConsoleNotification);

            Console.WriteLine($"Total cost for $50 after tax for Poland is: ${totalCost}");
        }

        private static void ConsoleNotification(string message)
        {
            Console.WriteLine($"NOTIFICATION: {message}");
        }
    }
}