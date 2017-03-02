using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main()
        {
            var demons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var demonBook = new SortedDictionary<string, string>();

            foreach (var demon in demons)
            {
                var healthPoints = GetHealth(demon);
                var damage = GetDamage(demon);

                demonBook[demon] = $"{demon} - {healthPoints} health, {damage:F2} damage";
            }

            foreach (var demon in demonBook)
            {
                Console.WriteLine(demon.Value);
            }
        }

        private static object GetDamage(string demon)
        {
            Regex pattern = new Regex(@"(\-|\+|)[0-9]+(\.|[0-9]|)([0-9]+|)");

            var damageItems = pattern.Matches(demon);
            double damage = 0;

            foreach (var item in damageItems)
            {
                damage += double.Parse(item.ToString());
            }

            Regex regex = new Regex(@"[\*\/]");

            var mathes = regex.Matches(demon);

            foreach (var match in mathes)
            {
                foreach (var item in match.ToString())
                {
                    if (item.Equals('/'))
                    {
                        damage /= 2;
                    }
                    else
                    {
                        damage *= 2;
                    }
                }
            }

            return damage;
        }

        private static object GetHealth(string demon)
        {
            Regex pattern = new Regex(@"[^0-9\+\-\*\/\.]");

            var healthItems = pattern.Matches(demon);
            var healthPoints = 0;

            foreach (var item in healthItems)
            {
                foreach (var health in item.ToString())
                {
                    healthPoints += health;
                }
            }

            return healthPoints;
        }
    }
}