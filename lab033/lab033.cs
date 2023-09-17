using System;

public class Currency
{
    private double Value { get; set; }

    public Currency(double value)
    {
        Value = value;
    }

    public CurrencyUSD ToUSD()
    {
        return new CurrencyUSD(Value);
    }

    public CurrencyEUR ToEUR()
    {
        return new CurrencyEUR(Value);
    }

    public CurrencyRUB ToRUB()
    {
        return new CurrencyRUB(Value);
    }
}

public class CurrencyUSD : Currency
{
    public CurrencyUSD (double value) : base(value)
    {
    }

    public CurrencyEUR ToEUR(double value)
    {
        return new CurrencyEUR(value * 0.93);
    }

    public CurrencyRUB ToRUB(double value)
    {
        return new CurrencyRUB(value * 96);
    }
}

public class CurrencyEUR : Currency
{
    public CurrencyEUR(double value) : base(value)
    {
    }

    public CurrencyUSD ToUSD(double value)
    {
        return new CurrencyUSD(value * 1.07);
    }

    public CurrencyRUB ToRUB(double value)
    {
        return new CurrencyRUB(value * 101);
    }
}

public class CurrencyRUB : Currency
{
    public CurrencyRUB(double value) : base(value)
    {
    }

    public CurrencyUSD ToUSD(double value)
    {
        return new CurrencyUSD(value * 0.01);
    }

    public CurrencyEUR ToEUR(double value)
    {
        return new CurrencyEUR(value * 0.01);
    }
}

class lab033
{
    static void Main()
    {
        Currency baseCurrency = new Currency(100);
        CurrencyUSD usd = baseCurrency.ToUSD();

        CurrencyRUB rub = usd.ToRUB();
        CurrencyEUR eur = usd.ToEUR();

        Console.WriteLine($"USD: {usd}");
        Console.WriteLine($"EUR: {eur}");
        Console.WriteLine($"RUB: {rub}");
    }
}
