using System.Collections.Generic;

namespace DexscreenerApiManager.Component
{
    public class DexscreenerResponse
    {
        public string schemaVersion { get; set; }
        public List<Pair> pairs { get; set; }
        public Pair pair { get; set; }
    }
    
    public class BaseToken
    {
        public string address { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class H1
    {
        public int buys { get; set; }
        public int sells { get; set; }
    }

    public class H24
    {
        public int buys { get; set; }
        public int sells { get; set; }
    }

    public class H6
    {
        public int buys { get; set; }
        public int sells { get; set; }
    }

    public class Liquidity
    {
        public double usd { get; set; }
        public double @base { get; set; }
        public double quote { get; set; }
    }

    public class M5
    {
        public int buys { get; set; }
        public int sells { get; set; }
    }

    public class Pair
    {
        public string chainId { get; set; }
        public string dexId { get; set; }
        public string url { get; set; }
        public string pairAddress { get; set; }
        public List<string> labels { get; set; }
        public BaseToken baseToken { get; set; }
        public QuoteToken quoteToken { get; set; }
        public string priceNative { get; set; }
        public string priceUsd { get; set; }
        public Txns txns { get; set; }
        public Volume volume { get; set; }
        public PriceChange priceChange { get; set; }
        public Liquidity liquidity { get; set; }
        public int fdv { get; set; }
        public long pairCreatedAt { get; set; }
    }

    public class Pair2
    {
        public string chainId { get; set; }
        public string dexId { get; set; }
        public string url { get; set; }
        public string pairAddress { get; set; }
        public List<string> labels { get; set; }
        public BaseToken baseToken { get; set; }
        public QuoteToken quoteToken { get; set; }
        public string priceNative { get; set; }
        public string priceUsd { get; set; }
        public Txns txns { get; set; }
        public Volume volume { get; set; }
        public PriceChange priceChange { get; set; }
        public Liquidity liquidity { get; set; }
        public int fdv { get; set; }
        public long pairCreatedAt { get; set; }
    }

    public class PriceChange
    {
        public double m5 { get; set; }
        public double h1 { get; set; }
        public double h6 { get; set; }
        public double h24 { get; set; }
    }

    public class QuoteToken
    {
        public string address { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Txns
    {
        public M5 m5 { get; set; }
        public H1 h1 { get; set; }
        public H6 h6 { get; set; }
        public H24 h24 { get; set; }
    }

    public class Volume
    {
        public double h24 { get; set; }
        public double h6 { get; set; }
        public double h1 { get; set; }
        public double m5 { get; set; }
    }
}