using System;

public class Currency
{
    private double _value;

    public double Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public Currency(double value)
    {
        _value = value;
    }

}

public class CurrencyUSD : Currency
{
    public CurrencyUSD(double value) : base(value)
    {
    }

    public CurrencyEUR ToEUR()
    {
        double exchangeRate = 0.93;
        return new CurrencyEUR(Value * exchangeRate);
    }

    public CurrencyRUB ToRUB()
    {
        double exchangeRate = 96;
        return new CurrencyRUB(Value * exchangeRate);
    }
}

public class CurrencyEUR : Currency
{
    public CurrencyEUR(double value) : base(value)
    {
    }

    public CurrencyUSD ToUSD()
    {
        double exchangeRate = 1.07;
        return new CurrencyUSD(Value * exchangeRate);
    }

    public CurrencyRUB ToRUB()
    {
        double exchangeRate = 102;
        return new CurrencyRUB(Value * exchangeRate);
    }
}

public class CurrencyRUB : Currency
{
    public CurrencyRUB(double value) : base(value)
    {
    }

    public CurrencyUSD ToUSD()
    {
        double exchangeRate = 0.013;
        return new CurrencyUSD(Value * exchangeRate);
    }

    public CurrencyEUR ToEUR()
    {
        double exchangeRate = 0.01;
        return new CurrencyEUR(Value * exchangeRate);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select the amount of currency:");
        double n = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select the type of currency:");
        string type = Console.ReadLine();

        switch (type)
        {
            case "USD":
                CurrencyUSD usd = new CurrencyUSD(n);
                Console.WriteLine($"We have: {usd.Value}");

                CurrencyUSD usd1 = usd;
                CurrencyEUR eur1 = usd.ToEUR();
                CurrencyRUB rub1 = usd.ToRUB();

                Console.WriteLine($"\nUSD from RUB: {usd1.Value}");
                Console.WriteLine($"EUR from USD: {eur1.Value}");
                Console.WriteLine($"RUB from EUR: {rub1.Value}");

                break;
            case "EUR":
                CurrencyEUR eur = new CurrencyEUR(n);
                Console.WriteLine($"We have: {eur.Value}");

                CurrencyUSD usd2 = eur.ToUSD();
                CurrencyEUR eur2 = eur;
                CurrencyRUB rub2 = eur.ToRUB();

                Console.WriteLine($"\nUSD from RUB: {usd2.Value}");
                Console.WriteLine($"EUR from USD: {eur2.Value}");
                Console.WriteLine($"RUB from EUR: {rub2.Value}");

                break;
            case "RUB":
                CurrencyRUB rub = new CurrencyRUB(n);
                Console.WriteLine($"We have: {rub.Value}");

                CurrencyUSD usd3 = rub.ToUSD();
                CurrencyEUR eur3 = rub.ToEUR();
                CurrencyRUB rub3 = rub;

                Console.WriteLine($"\nUSD from RUB: {usd3.Value}");
                Console.WriteLine($"EUR from USD: {eur3.Value}");
                Console.WriteLine($"RUB from EUR: {rub3.Value}");

                break;
            default:
                Console.WriteLine("Try again now");
                break;
        }
    }
}
