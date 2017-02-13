using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var numbers = new List<int>();

            foreach (var number in input)
            {
                numbers.Add(int.Parse(number));
            }

            var command = Console.ReadLine().Split();
            while (command[0] != "print")
            {
                var index = 0;
                var element = 0;
                var positions = 0;

                switch (command[0])
                {
                    case "add":
                        index = int.Parse(command[1]);
                        element = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;

                    case "addMany":
                        index = int.Parse(command[1]);
                        for (int i = 2; i <= command.Length - 1; i++)
                        {
                            element = int.Parse(command[i]);
                            numbers.Insert(index + i - 2 , element);
                        }

                        break;

                    case "contains":
                        element = int.Parse(command[1]);
                        Console.WriteLine(numbers.IndexOf(element));
                        break;

                    case "remove":
                        index = int.Parse(command[1]);
                        numbers.RemoveAt(index);
                        break;

                    case "shift":
                        positions = int.Parse(command[1]);
                        for (int i = 0; i < positions; i++)
                        {
                            var temp = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }

                            numbers[numbers.Count - 1] = temp;
                        }

                        break;

                    case "sumPairs":
                        var newList = new List<int>();
                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            if (i % 2 == 0)
                            {
                                newList.Add(numbers[i] + numbers[i + 1]);
                            }
                        }

                        if (numbers.Count % 2 != 0)
                        {
                            newList.Add(numbers[numbers.Count-1]);
                        }

                        numbers = newList;
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");

        }
    }
}
