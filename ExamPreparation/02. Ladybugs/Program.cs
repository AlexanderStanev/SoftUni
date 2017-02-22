using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = long.Parse(Console.ReadLine());
            var indexesOfBugs = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            var listOfCurrentBugs = new long[fieldSize];
            for (int i = 0; i < fieldSize - 1; i++)
            {
                if (indexesOfBugs.Contains(i))
                {
                    listOfCurrentBugs[i] = 1;
                }
                else
                {
                    listOfCurrentBugs[i] = 0;
                }
            }

            var command = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "end")
            {
                var bugStartingPosition = long.Parse(command[0]);

                var bugDirection = command[1];
                var bugFlyLenght = long.Parse(command[2]);

                if (bugFlyLenght < 0)
                {
                    bugFlyLenght = Math.Abs(bugFlyLenght);
                    if (bugDirection == "right")
                    {
                        bugDirection = "left";
                    }
                    else
                    {
                        bugDirection = "right";
                    }
                }

                if (listOfCurrentBugs[bugStartingPosition] == 0)
                {
                    command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                var ladyBugIsOutOrFoundPlace = false;
                if (bugDirection == "right" )
                {
                    var bugWannaBePosition = bugStartingPosition + bugFlyLenght;

                    if (bugWannaBePosition >= fieldSize - 1)
                    {
                        listOfCurrentBugs[bugStartingPosition] = 0;
                        command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }

                    while (!ladyBugIsOutOrFoundPlace) // was listOfCurrentBugs[bugWannaBePosition] == 1 // 
                    {
                        bugWannaBePosition++;

                        if (bugWannaBePosition >= fieldSize - 1)
                        {
                            listOfCurrentBugs[bugStartingPosition] = 0;
                            command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            continue;
                        }
                    }

                    listOfCurrentBugs[bugStartingPosition] = 0;
                    listOfCurrentBugs[bugWannaBePosition] = 1;
                }
                else // bugDiration == "left"
                {
                    var bugWannaBePosition = bugStartingPosition - bugFlyLenght;

                    if (bugWannaBePosition < 0 )
                    {
                        listOfCurrentBugs[bugStartingPosition] = 0;
                        command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    
                    while (!ladyBugIsOutOrFoundPlace) // was listOfCurrentBugs[bugWannaBePosition] == 1 // 
                    {
                        bugWannaBePosition--;

                        if (bugWannaBePosition < 0)
                        {
                            ladyBugIsOutOrFoundPlace = true;
                        }
                    }

                    listOfCurrentBugs[bugStartingPosition] = 0;
                    listOfCurrentBugs[bugWannaBePosition] = 1;
                }

            command = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", listOfCurrentBugs));
        }
    }
}
