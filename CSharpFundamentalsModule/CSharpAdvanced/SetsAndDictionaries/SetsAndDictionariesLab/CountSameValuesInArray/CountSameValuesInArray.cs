namespace CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            var numbers = new SortedDictionary<float, int>();

            var input = Console.ReadLine().Split(new []{ ' ' } , StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                var number = float.Parse(item);
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers.Add(number, 1);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
