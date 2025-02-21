﻿namespace StockDataApp.Core.FinnhubModels
{
    public class CompanyProfileResult
    {
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Exchange { get; set; }
        public DateTime Ipo { get; set; }
        public double MarketCapitalization { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public double ShareOutstanding { get; set; }
        public string Ticker { get; set; }
        public string WebUrl { get; set; }
        public string Logo { get; set; }
        public string FinnhubIndustry { get; set; }
    }
}
