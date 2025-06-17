namespace QualcoLab2025.Task7
{


    using Xunit; // Import the xUnit namespace


    public class PriceCalculator
    {
        public decimal GrossValue(decimal initialValue, decimal vat) => initialValue * (1 + vat);
    }



    public class PriceCalculatorTests
    {
        

    }
}