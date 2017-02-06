using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var materials = new Dictionary<string, int>
            {
                {"shards", 0}, {"motes", 0}, {"fragments", 0 }
            };

            bool dontBreak = true;
            while (dontBreak)
            {
                var quantity = 0;
                var material = string.Empty;

                var input = Console.ReadLine().ToLower().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i = i + 2)
                {
                    quantity = int.Parse(input[i]);
                    material = input[i+1];
                    
                    if (!materials.ContainsKey(material))
                    {
                        materials.Add(material,0);
                    }
                    
                    materials[material] += quantity;

                    if (materials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        materials["shards"] -= 250;

                        var specialMaterials = materials.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                        var junkMaterials = materials.Skip(3).OrderBy(x => x.Key);

                        PrintPairs(specialMaterials);
                        PrintPairs(junkMaterials);

                        dontBreak = false;
                        break;
                    }
                    else if (materials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        materials["fragments"] -= 250;

                        var specialMaterials = materials.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                        var junkMaterials = materials.Skip(3).OrderBy(x => x.Key);

                        PrintPairs(specialMaterials);
                        PrintPairs(junkMaterials);

                        dontBreak = false;
                        break;
                    }

                    else if (materials["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        materials["motes"] -= 250;

                        var specialMaterials = materials.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                        var junkMaterials = materials.Skip(3).OrderBy(x => x.Key);

                        PrintPairs(specialMaterials);
                        PrintPairs(junkMaterials);

                        dontBreak = false;
                        break;
                    }
                }
            }
        }

        private static void PrintPairs(IOrderedEnumerable<KeyValuePair<string, int>> specialMaterials)
        {
            foreach (var special in specialMaterials)
            {
                Console.WriteLine($"{special.Key}: {special.Value}");
            }
        }
    }
}
