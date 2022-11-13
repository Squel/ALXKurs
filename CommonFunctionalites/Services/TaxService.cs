using CommonFunctionalites.Services.Interface;

namespace CommonFunctionalites.Services
{
    public class TaxService : ITaxService
    {
        private const double VatPrecentage = 0.23;
        private const double GovernmentPrecentage = 0.17;

        public double CalculateTax(double income)
        {

            var vatTax = CalculateVat(income);
            var govermentTax = CalculateGovermentTax(income, vatTax);
            return vatTax + govermentTax;
        }

        private double CalculateGovermentTax(double income, double vatTax)
        {
            return (income - vatTax) * GovernmentPrecentage;
        }

        private double CalculateVat(double income)
        {
            return income * VatPrecentage;
        }
    }
}
