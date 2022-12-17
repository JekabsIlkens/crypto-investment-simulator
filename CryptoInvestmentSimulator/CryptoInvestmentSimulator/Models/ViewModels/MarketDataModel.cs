﻿namespace CryptoInvestmentSimulator.Models.ViewModels
{
    public class MarketDataModel
    {
        public int Id { get; set; }
        public DateTime CollectionTime { get; set; }
        public decimal UnitValue { get; set; }
        public decimal Change24h { get; set; }
        public decimal Change7d { get; set; }
        public int Crypto { get; set; }
        public int Fiat { get; set; }
    }
}
