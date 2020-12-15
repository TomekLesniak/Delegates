using System;

namespace DelegatesLibrary
{
    public class TotalCostCalculator
    {
        private decimal _price;

        public TotalCostCalculator(decimal price)
        {
            _price = price;
        }

        public decimal CalculateTotalCost(Func<decimal, decimal> calculateTax, Action<string> notifyUser)
        {
            var taxForGivenCountry = calculateTax(_price);
            _price += taxForGivenCountry;

            if (IsEligibleForDiscount())
            {
                notifyUser("You have received a discount!");
                ApplyDiscount();
            }

            return _price;
        }

        private bool IsEligibleForDiscount()
        {
            return _price >= 100.0M;
        }

        private void ApplyDiscount()
        {
            _price -= 10.0M;
        }

    }
}