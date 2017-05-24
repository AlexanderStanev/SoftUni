using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splitedUsernames = input.Split(new[] {' ', '\\', '/', ')', '('}, StringSplitOptions.RemoveEmptyEntries);

            var validUsernamesAndSize = new Dictionary<string,int>();
            var pattern = @"^[a-zA-Z]\w{2,24}";

            Regex regex = new Regex(pattern);

            foreach (var username in splitedUsernames)
            {
                if (regex.IsMatch(username))
                {
                    validUsernamesAndSize.Add(username, username.Length);
                  //Console.WriteLine(username);
                }
            }

            var summedPairsSize = new List<int>();

            var temp = validUsernamesAndSize.First().Value;
            foreach (var username in validUsernamesAndSize.Skip(1))
            {
                summedPairsSize.Add(username.Value + temp);
                temp = username.Value;
            }

            var indexOfFirstElement = 0;
            for (int i = 0; i < summedPairsSize.Count; i++)
            {
                if (summedPairsSize[i] == summedPairsSize.Max())
                {
                    indexOfFirstElement = i;
                    break;
                }
            }

            var usernamesOnly = validUsernamesAndSize.Keys.ToList();

            Console.WriteLine(usernamesOnly[indexOfFirstElement]);
            Console.WriteLine(usernamesOnly[indexOfFirstElement + 1]);

            // Здравей ако четеш това значи е много вероятно да се пръскаш от смях :D
            // Смея да твърдя, че се постарах да изглежда максимално грозно! БЛАГОДАРЯ
        }
    }
}
