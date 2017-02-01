using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            var specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var bombNumber = specialNumbers[0];
            var bombPower = specialNumbers[1];

            var bombsIndexList = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == bombNumber)
                {
                    bombsIndexList.Add(sequence.IndexOf(bombNumber, i));
                }
            }

            for (int i = 0; i < sequence.Count; i++)
            {
               // if (i = )
                {

                }
            }

            for (int i = 0; i < bombsIndexList.Count; i++)
            {
                Console.WriteLine(bombsIndexList[i]);
            }
        }
    }
}
