using System;
using System.Collections.Generic;


namespace CurrencyYup2
{
    class Currency
    {
        public Dictionary<string, decimal> currencies = new Dictionary<string, decimal>()
        {
            {
                "Dollar", 1M
            },
            {
                "Manat", 1.7M
            },
            {
                "Euro",0.9M
            },
            {
                "Tl",5M
            }
        };

        public Dictionary<string,decimal> Convert(decimal inputValue,string inputCurrency)
        {
            Dictionary<string, decimal> outputCurrency = new Dictionary<string, decimal>();
            decimal n = inputValue / currencies[inputCurrency];
            foreach (var item in currencies)
            {
                if(item.Key!=inputCurrency)
                outputCurrency.Add(item.Key, n * item.Value);
            }
            return outputCurrency;
        }
    }
}
