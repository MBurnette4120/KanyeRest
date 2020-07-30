using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeRest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

        }
    }
}
