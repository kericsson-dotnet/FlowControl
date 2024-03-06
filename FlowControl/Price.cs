internal class Price
{
    // Misstänker att denna lösning med enums inte är helt idiomatisk i C#, saknar Rust enums lite. Ville testa om det gick :)
    // Castar enumen till int senare då detta är den underliggande typen.
    public enum PriceCategory
    {
        Free = 0,
        Youth = 80,
        Pensioner = 90,
        Standard = 120
    }

    public List<PriceCategory> visitors;

    public Price()
    {
        visitors = new List<PriceCategory>();
    }

    internal void AddVisitor(uint age)
    {
        visitors.Add(CheckCategory(age));

    }

    internal static PriceCategory CheckCategory(uint age)
    {
        if (age < 5 || age > 100)
        {
            return PriceCategory.Free;
        }
        else if (age < 20)
        {
            return PriceCategory.Youth;
        }
        else if (age > 64)
        {
            return PriceCategory.Pensioner;
        }
        else
        {
            return PriceCategory.Standard;
        }

    }

    internal int VisitorsPriceSum()
    {
        int sum = 0;
        foreach (var visitor in visitors)
        {
            // Cast för att få den associerade inten till enumvärdet.
            sum += (int)visitor;
        };
        return sum;
    }


    internal static void PrintPriceCategory(PriceCategory category)
    {
        Console.WriteLine($"{category}: {(int)category}kr");
    }

}
