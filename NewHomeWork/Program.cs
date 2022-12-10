namespace NewHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("Italia",59000000);    
            country.City.Add(new City("Milan", 1400000));
            country.City.Add(new City("Roma", 2800000));
            country.City.Add(new City("Verona", 270000));
            country.City.Add(new City("Venica", 260000));
            country.City.Add(new City("Naplec", 940000));
            country.City.Add(new City("Palermo", 160000));
            country.City.Add(new City("Florence", 380000));
            country.City.Add(new City("Bologna", 390000));
            country.City.Add(new City("Turin", 890000));
            country.FindPopulation(0, 1000000);

            Console.WriteLine("--------------------------------------");
            Country country1 = new Country("USA", 331000000);
            country1.City.Add(new City("New York", 8800000));
            country1.City.Add(new City("San Diego",1400000));
            country1.City.Add(new City("San Jose", 1000000));
            country1.City.Add(new City("Chicago", 2700000));
            country1.City.Add(new City("Boston", 680000));
            country1.City.Add(new City("Philadelphia", 1600000));
            country1.City.Add(new City("Los Angeles", 3900000));
            country1.City.Add(new City("San Francisco", 820000));
            country1.City.Add(new City("Miami", 439000));
            country1.FindPopulation(0, 5000000);
        }
    }
}