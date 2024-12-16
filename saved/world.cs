namespace CountryExcersize
{
    abstract class World
    {
        public string PlanetName { get; set; } = "Earth";

        public EContinents Continents { get; set; }
    }

    class Country(string countryName, string capital, ECurrencies? currency) : World
    {
        public string CountryName { get; set; } = countryName ?? "Unknown";

        public string Capital { get; set; } = capital ?? "Unkown";

        public ECurrencies Currency { get; set; } = currency ?? ECurrencies.USD;

        public CountryLanguages Languages { get; set; }

        public void SayHi()
        {
            Console.WriteLine($"Hi there...");
        }

        public void SayHi(string country)
        {
            Console.WriteLine($"Welcome from {country}");
        }

        public void SayHi(string country, ECurrencies currency)
        {
            Console.WriteLine($"Hello from {country}, here, we use {currency} to buy stuff.");
        }
    }

    struct CountryLanguages(ELanguages firstLang, ELanguages secondLang)
    {
        public string FirstLang { get; set; } = firstLang.ToString() ?? "Unknown";
        public string SecondLang { get; set; } = secondLang.ToString() ?? "Unknown";
    }

    enum EContinents
    {
        Asia,
        Africa,
        Antarctica,
        Australia,
        Europe,
        NorthAmerica,
        SouthAmerica,
    }

    enum ECurrencies
    {
        USD,
        GEL,
        RUB,
        EUR,
        PND,
    }

    enum ELanguages
    {
        ENGLISH,
        GEORGIAN,
        RUSSIAN,
        CHZEC,
        SPANISH,
    }
}
