namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TruckTour
    {
        static void Main(string[] args)
        {
            var pumpsCount = long.Parse(Console.ReadLine());

            var pumps = new Queue<string>();

            for (int i = 0; i < pumpsCount; i++)
            {
                var pump = Console.ReadLine();

                pumps.Enqueue(pump);
            }

            var willMakeIt = false;

            for (int i = 0; i < pumpsCount; i++)
            {
                var fuel = 0l;

                foreach (var pump in pumps)
                {
                    var pumpInfo = pump.Split(' ');
                    var amountOfPetrol = long.Parse(pumpInfo[0]);
                    var distanceToNextPump = long.Parse(pumpInfo[1]);

                    fuel += amountOfPetrol;
                    fuel -= distanceToNextPump;

                    if (fuel < 0)
                    {
                        willMakeIt = false;
                        break;
                    }
                    else
                    {
                        willMakeIt = true;
                    }
                }

                if (willMakeIt)
                {
                    Console.WriteLine(i);
                    return;
                }

                var currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
            }

        }
    }
}
