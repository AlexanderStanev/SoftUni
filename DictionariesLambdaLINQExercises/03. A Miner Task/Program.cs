using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();

            var resources = new Dictionary<string, long>();

            while (firstInput != "stop")
            {
                var secondInput = long.Parse(Console.ReadLine());
                if (resources.ContainsKey(firstInput))
                {
                    resources[firstInput] =+ secondInput;
                }

                else
                {
                    resources[firstInput] = secondInput;
                }

                firstInput = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
