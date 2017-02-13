using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');

            var countries = new Dictionary<string, List<string>>();
            var populationInCities = new Dictionary<string, int>();

            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var people = int.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new List<string>()); 
                }

                countries[country].Add(city);


                if (!populationInCities.ContainsKey(city))
                {
                    populationInCities.Add(city, 0);
                }

                populationInCities[city] += people;

                input = Console.ReadLine().Split('|');
            }
        }
    }
}
