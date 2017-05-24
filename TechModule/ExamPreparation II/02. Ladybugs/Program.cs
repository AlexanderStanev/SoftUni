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
            var fieldsCount = ushort.Parse(Console.ReadLine());
            var ladybugs = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var field = new byte[fieldsCount];

            for (int i = 0; i < ladybugs.Count; i++)
            {
                if (ladybugs[i] >= 0 && ladybugs[i] < fieldsCount)
                {
                    field[ladybugs[i]] = 1;
                }
            }

            var command = new List<string>();
            while (true)
            {
                command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "end") break;

                var index = int.Parse(command[0]);
                if (index < 0 || index >= fieldsCount) continue;
                if (field[index] == 0) continue;

                var flyLength = int.Parse(command[2]);

                field[index] = 0;
                var nextIndex = index;

                if (command[1] == "left")
                    nextIndex -= flyLength;
                else
                    nextIndex += flyLength;

                while (nextIndex >= 0 && nextIndex < fieldsCount)
                {
                    if (field[nextIndex] == 0)
                    {
                        field[nextIndex] = 1;
                        break;
                    }

                    if (command[1] == "left")
                        nextIndex -= flyLength;
                    else
                        nextIndex += flyLength;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
