namespace CountSymbols
{
    using System;
    using System.Collections.Generic;

    class CountSymbols
    {
        static void Main(string[] args)
        {
            var dic = new SortedDictionary<char, int>();

            var input = Console.ReadLine();

            foreach (var symbol in input)
            {
                if (dic.ContainsKey(symbol))
                {
                    dic[symbol]++;
                }
                else
                {
                    dic.Add(symbol, 1);
                }
            }

            foreach (var KVP in dic)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value} time/s");
            }
        }
    }
}
