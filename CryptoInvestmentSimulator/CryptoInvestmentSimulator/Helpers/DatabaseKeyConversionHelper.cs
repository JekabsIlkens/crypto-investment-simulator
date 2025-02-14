﻿using System;

namespace CryptoInvestmentSimulator.Helpers
{
    public static class DatabaseKeyConversionHelper
    {
        /// <summary>
        /// Converts string type time zone into coresponding database key.
        /// </summary>
        /// <param name="timeZone">String time zone.</param>
        /// <returns>
        /// Time zone database primary key.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int TimeZoneToDbKey(string timeZone)
        {
            return timeZone switch
            {
                "GMT-12:00" => 1,
                "GMT-11:00" => 2,
                "GMT-10:00" => 3,
                "GMT-09:00" => 4,
                "GMT-08:00" => 5,
                "GMT-07:00" => 6,
                "GMT-06:00" => 7,
                "GMT-05:00" => 8,
                "GMT-04:00" => 9,
                "GMT-03:00" => 10,
                "GMT-02:00" => 11,
                "GMT-01:00" => 12,
                "GMT+00:00" => 13,
                "GMT+01:00" => 14,
                "GMT+02:00" => 15,
                "GMT+03:00" => 16,
                "GMT+04:00" => 17,
                "GMT+05:00" => 18,
                "GMT+06:00" => 19,
                "GMT+07:00" => 20,
                "GMT+08:00" => 21,
                "GMT+09:00" => 22,
                "GMT+10:00" => 23,
                "GMT+11:00" => 24,
                "GMT+12:00" => 25,
                _ => throw new ArgumentOutOfRangeException(nameof(timeZone)),
            };
        }

        /// <summary>
        /// Converts the database primary key of time zone into coresponding string value.
        /// </summary>
        /// <param name="timeZone">Time zone primary key.</param>
        /// <returns>
        /// String time zone.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string TimeZoneKeyToString(int timeZone)
        {
            return timeZone switch
            {
                1 => "GMT-12:00",
                2 => "GMT-11:00",
                3 => "GMT-10:00",
                4 => "GMT-09:00",
                5 => "GMT-08:00",
                6 => "GMT-07:00",
                7 => "GMT-06:00",
                8 => "GMT-05:00",
                9 => "GMT-04:00",
                10 => "GMT-03:00",
                11 => "GMT-02:00",
                12 => "GMT-01:00",
                13 => "GMT+00:00",
                14 => "GMT+01:00",
                15 => "GMT+02:00",
                16 => "GMT+03:00",
                17 => "GMT+04:00",
                18 => "GMT+05:00",
                19 => "GMT+06:00",
                20 => "GMT+07:00",
                21 => "GMT+08:00",
                22 => "GMT+09:00",
                23 => "GMT+10:00",
                24 => "GMT+11:00",
                25 => "GMT+12:00",
                _ => throw new ArgumentOutOfRangeException(nameof(timeZone)),
            };
        }

        /// <summary>
        /// Converts crypto symbol to coresponding database primary key.
        /// </summary>
        /// <param name="crypto">Crypto symbol.</param>
        /// <returns>
        /// Crypto symbol pripary key.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int CryptoSymbolToDbKey(string crypto)
        {
            return crypto switch
            {
                "BTC" => 1,
                "ETH" => 2,
                "ADA" => 3,
                "ATOM" => 4,
                "DOGE" => 5,
                _ => throw new ArgumentOutOfRangeException(nameof(crypto)),
            };
        }

        /// <summary>
        /// Converts the database primary key of crypto symbol intto coresponding symbol string.
        /// </summary>
        /// <param name="crypto">Crypto database key.</param>
        /// <returns>
        /// Crypto symbol.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string CryptoKeyToSymbol(int crypto)
        {
            return crypto switch
            {
                1 => "BTC",
                2 => "ETH",
                3 => "ADA",
                4 => "ATOM",
                5 => "DOGE",
                _ => throw new ArgumentOutOfRangeException(nameof(crypto)),
            };
        }

        /// <summary>
        /// Converts fiat symbol to coresponding database primary key.
        /// </summary>
        /// <param name="fiat">Fiat symbol.</param>
        /// <returns>
        /// Primary key of fiat symbol.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int FiatSymbolToDbKey(string fiat)
        {
            return fiat switch
            {
                "EUR" => 1,
                _ => throw new ArgumentOutOfRangeException(nameof(fiat)),
            };
        }

        /// <summary>
        /// Converts the database primary key of fiat symbol intto coresponding fiat string.
        /// </summary>
        /// <param name="fiat">Fiat database key.</param>
        /// <returns>
        /// Fiat symbol.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string FiatKeyToSymbol(int fiat)
        {
            return fiat switch
            {
                1 => "EUR",
                _ => throw new ArgumentOutOfRangeException(nameof(fiat)),
            };
        }

        /// <summary>
        /// Converts leverage string into coresponding databas primary key.
        /// </summary>
        /// <param name="leverageMultiplier">String leverage ratio</param>
        /// <returns>
        /// Primary key of leverage ratio.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int LeverageStringToDbKey(string leverageMultiplier)
        {
            return leverageMultiplier switch
            {
                "None" => 1,
                "2x" => 2,
                "5x" => 3,
                "10x" => 4,
                _ => throw new ArgumentOutOfRangeException(nameof(leverageMultiplier)),
            };
        }

        /// <summary>
        /// Converts leverage ratio primary key into string value.
        /// </summary>
        /// <param name="ratioId">Leverage ratio primary key.</param>
        /// <returns>
        /// Leverage ratio string.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string LeverageKeyToString(int ratioId)
        {
            return ratioId switch
            {
                1 => "None",
                2 => "2x",
                3 => "5x",
                4 => "10x",
                _ => throw new ArgumentOutOfRangeException(nameof(ratioId)),
            };
        }
    }
}
