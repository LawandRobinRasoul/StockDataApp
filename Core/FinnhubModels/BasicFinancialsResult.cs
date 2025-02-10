using System.Text.Json;
using System.Text.Json.Serialization;

namespace StockDataApp.Core.FinnhubModels
{
    public class Metric
    {
        [JsonPropertyName("10DayAverageTradingVolume")]
        public double TenDayAverageTradingVolume { get; set; }

        [JsonPropertyName("52WeekHigh")]
        public double FiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("52WeekLow")]
        public double FiftyTwoWeekLow { get; set; }

        [JsonPropertyName("52WeekLowDate")]
        public string FiftyTwoWeekLowDate { get; set; }

        [JsonPropertyName("52WeekPriceReturnDaily")]
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

        [JsonPropertyName("v")]
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
