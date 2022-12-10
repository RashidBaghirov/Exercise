using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork.Main
{
    internal class City
    {
        public string Name { get; set; }
        public double Population;

        public City(string name, double population)
        {
            Name = name;
            Population = population;
        }

    }
}
