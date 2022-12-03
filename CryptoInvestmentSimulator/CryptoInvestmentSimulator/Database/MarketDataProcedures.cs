﻿using CryptoInvestmentSimulator.Constants;
using CryptoInvestmentSimulator.Enums;
using CryptoInvestmentSimulator.Helpers;
using CryptoInvestmentSimulator.Models.ViewModels;
using MySql.Data.MySqlClient;

namespace CryptoInvestmentSimulator.Database
{
    public class MarketDataProcedures
    {
        private readonly DatabaseContext context;

        public MarketDataProcedures(DatabaseContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Inserts new market data into database.
        /// </summary>
        /// <param name="marketDataModel"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void InsertNewMarketDataEntry(MarketDataModel marketDataModel)
        {
            if (marketDataModel == null)
            {
                throw new ArgumentNullException(nameof(marketDataModel));
            }

            var formattedDateTime = DateTimeFormatHelper.ToDbFormatAsString(marketDataModel.CollectionDateTime);

            var valuesString = $"'{marketDataModel.CryptoSymbol}', '{marketDataModel.FiatSymbol}', '{formattedDateTime}'," +
                $" {marketDataModel.FiatPricePerUnit}, {marketDataModel.PercentChange24h}, {marketDataModel.PercentChange7d}";

            using (MySqlConnection connection = context.GetConnection())
            {
                connection.Open();
                MySqlCommand command = new($"INSERT INTO market_data ({DatabaseConstants.MarketDataColumns}) VALUES ({valuesString})", connection);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Collects specified amount of historical chart points
        /// into a list for specified cryptocurrency.
        /// </summary>
        /// <param name="crypto"></param>
        /// <param name="rowCount"></param>
        /// <returns>List of <see cref="ChartPointModel"/>s</returns>
        /// <exception cref="ArgumentException"></exception>
        public List<ChartPointModel> GetMarketHistory(CryptoEnum crypto, int rowCount)
        {
            if (rowCount <= 0)
            {
                throw new ArgumentException($"Requested {rowCount} rows! Invalid!");
            }

            var chartPoints = new List<ChartPointModel>();

            using (var connection = context.GetConnection())
            {
                connection.Open();
                MySqlCommand command = new(
                    $"SELECT date_time, unit_value FROM " +
                    $"(SELECT * FROM market_data WHERE crypto_symbol = '{crypto}' ORDER BY data_id DESC LIMIT {rowCount}) AS sub " +
                    $"ORDER BY data_id ASC ", 
                    connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var timePointStr = reader.GetValue(reader.GetOrdinal("date_time")).ToString();
                        var timePoint = ((DateTimeOffset)DateTime.Parse(timePointStr)).ToUnixTimeSeconds() * 1000;

                        var pricePointStr = reader.GetValue(reader.GetOrdinal("unit_value")).ToString();
                        var pricePoint = double.Parse(pricePointStr);

                        chartPoints.Add(new ChartPointModel(timePoint, pricePoint));
                    }
                }
            }

            return chartPoints;
        }
    }
}
