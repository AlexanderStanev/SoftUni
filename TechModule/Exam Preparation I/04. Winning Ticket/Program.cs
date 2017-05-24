using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                if (ticket.Length < 20 || ticket.Length > 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                Regex forFindingValidTickets = new Regex(@"^(.*?(@|#|\$|\^).*?)$");
                if (forFindingValidTickets.IsMatch(ticket))
                {
                    var halfSize = ticket.Length / 2;

                    var leftPart = ticket.ToString().Substring(0, halfSize);
                    var rightPart = ticket.ToString().Substring(halfSize);

                    if (CountingOnePart(rightPart).Symbol == CountingOnePart(leftPart).Symbol)
                    {
                        if ((CountingOnePart(rightPart).Count == 10 && CountingOnePart(leftPart).Count == 10))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {CountingOnePart(rightPart).Count}{CountingOnePart(rightPart).Symbol} Jackpot!");
                        }
                        else if (CountingOnePart(rightPart).Count > 5 && CountingOnePart(leftPart).Count > 5)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(CountingOnePart(rightPart).Count,CountingOnePart(leftPart).Count)}{CountingOnePart(rightPart).Symbol}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }

        private static Result CountingOnePart(string thisPart)
        {
            var specialSymbols = new[] { '@', '#', '$', '^' };

            var symbol = ' ';
            var maxCount = 0;
            var count = 1;
            var previousSymbol = thisPart[0];
            for (int i = 1; i < thisPart.Length; i++)
            {
                if (previousSymbol == thisPart[i])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        symbol = previousSymbol;
                    }

                    count = 1;
                }

                previousSymbol = thisPart[i];
            }

            if (count > maxCount)
            {
                maxCount = count;
                symbol = previousSymbol;
            }

            var result = new Result() { Symbol = symbol, Count = maxCount};
            return result;
        }
    }

    public class Result
    {
        public char Symbol { get; set; }
        public int Count { get; set; }
    }
}
