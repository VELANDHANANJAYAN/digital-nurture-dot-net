using System;

namespace FinancialForecastingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialValue = 1000;
            double growthRate = 0.05;
            int years = 5;

            double result = Forecaster.PredictFutureValue(initialValue, growthRate, years);
            Console.WriteLine($"Recursive: Value after {years} years = {result:F2}");

            double[] memo = new double[years + 1];
            double memoResult = Forecaster.PredictFutureValueMemo(initialValue, growthRate, years, memo);
            Console.WriteLine($"Memoized: Value after {years} years = {memoResult:F2}");
        }
    }
}
