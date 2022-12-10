using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork.Main
{
    internal class Country
    {
        public List<City> City = new List<City>();
        public string Name;
        public double TotalPopulation;
        public Country(string name, double totalpopulation)
        {
            Name = name;
            TotalPopulation = totalpopulation;
        }

        public void FindPopulation(double min, double max)
        {
            List<City> list = new List<City>();
            foreach (var city in City)
            {
                if (city.Population > min && city.Population < max)
                {
                    list.Add(city);
                    Console.WriteLine($"{city.Name}-{city.Population}");
                }
            }
            if (list.Count >= 0)
            {
                Console.WriteLine($"{Name}-{TotalPopulation}");
            }
        }

    }
}
