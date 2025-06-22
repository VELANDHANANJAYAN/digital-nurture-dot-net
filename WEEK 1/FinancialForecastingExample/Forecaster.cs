namespace FinancialForecastingExample
{
    public class Forecaster
    {
        public static double PredictFutureValue(double initialValue, double growthRate, int years)
        {
            if (years == 0)
                return initialValue;

            return PredictFutureValue(initialValue * (1 + growthRate), growthRate, years - 1);
        }

        public static double PredictFutureValueMemo(double initialValue, double growthRate, int years, double[] memo)
        {
            if (years == 0)
                return initialValue;

            if (memo[years] != 0)
                return memo[years];

            memo[years] = PredictFutureValueMemo(initialValue, growthRate, years - 1, memo) * (1 + growthRate);
            return memo[years];
        }
    }
}
