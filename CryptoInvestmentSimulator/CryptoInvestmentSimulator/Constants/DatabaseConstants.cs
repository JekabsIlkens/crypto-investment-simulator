﻿namespace CryptoInvestmentSimulator.Constants
{
    public static class DatabaseConstants
    {
        // Database configuration constants
        public static readonly string Access = "server=localhost;port=7770;database=cisdb;user=cisadmin;password=CISadminPASS";
        public static readonly string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        // Table constants
        public static readonly string UserColumns = "first_name, last_name, email_address, avatar_url";
        public static readonly string MarketDataColumns = "crypto_symbol, fiat_symbol, date_time, value_fiat, daily_change, weekly_change";
    }
}
