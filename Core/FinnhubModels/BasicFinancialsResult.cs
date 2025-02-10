namespace StockDataApp.Core.FinnhubModels
{
    public class Metric
    {
        public double TenDayAverageTradingVolume { get; set; }
        public double FiftyTwoWeekHigh { get; set; }
        public double FiftyTwoWeekLow { get; set; }
        public string FiftyTwoWeekLowDate { get; set; }
        public double FiftyTwoWeekPriceReturnDaily { get; set; }
        public double Beta { get; set; }
    }

    public class AnnualData
    {
        public List<FinancialMetric> CurrentRatio { get; set; }
        public List<FinancialMetric> SalesPerShare { get; set; }
        public List<FinancialMetric> NetMargin { get; set; }
    }

    public class FinancialMetric
    {
        public string Period { get; set; }
        public double Value { get; set; }
    }

    public class Series
    {
        public AnnualData Annual { get; set; }
    }

    public class BasicFinancialsResult
    {
        public Series Series { get; set; }
        public Metric Metric { get; set; }
        public string MetricType { get; set; }
        public string Symbol { get; set; }
    }
}
