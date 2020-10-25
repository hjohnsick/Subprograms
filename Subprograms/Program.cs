using System;

namespace Subprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyConverter usd = new CurrencyConverter();

            usd.LetUserConvertCurrency();

            Console.ReadKey();
        }
    }
}
