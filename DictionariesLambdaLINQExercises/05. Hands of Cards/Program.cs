using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardsPower = new Dictionary<char, int>
            {
                {'2',2}, {'3',3}, {'4',4},
                { '5',5}, {'6',6}, {'7',7},{'8',8},
                { '9',9},  {'J',11}, { 'Q',12},
                { 'K',13}, {'A',14}
            };

            var cardsType = new Dictionary<char, int>
            {
                {'S', 4}, {'H', 3}, {'D', 2}, {'C', 1}
            };

            var input = Console.ReadLine().Split(':');

            var playersCards = new Dictionary<string, List<string>>();
            var playersPoints = new Dictionary<string, long>();

            var currentPlayer = input[0];
            while (currentPlayer != "JOKER")
            {
                var currentPlayerCards = input[1];
                var listOfCurrentCards = currentPlayerCards.Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToList();

                if (playersCards.ContainsKey(currentPlayer))
                {
                    playersCards[currentPlayer] = playersCards[currentPlayer].Concat(listOfCurrentCards).Distinct().ToList();
                }
                else
                {
                    playersCards[currentPlayer] = listOfCurrentCards;
                }

                input = Console.ReadLine().Split(':');
                currentPlayer = input[0];
            }

            foreach (var player in playersCards)
            {
                var currentPoints = 0L;

                foreach (var cardPair in player.Value)
                {
                    if (cardPair.Length == 3)
                    {
                        currentPoints += 10 * cardsType[cardPair[2]];
                    }
                    else
                    {
                        currentPoints += cardsPower[cardPair[0]] * cardsType[cardPair[1]];
                    }
                }

                playersPoints[player.Key] = currentPoints;
            }

            foreach (var player in playersPoints)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }
    }
}
