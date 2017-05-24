using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new Dictionary<int, Dictionary<string, List<string>>>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Time for Code")
            {
                var info = input.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                var hashTag = info[1];

                if (hashTag[0] == '#')
                {
                    var id = int.Parse(info[0]);
                    var eventName = info[1].Substring(1);
                    var participants = info.Skip(2).ToList();
                    var participantsList = new List<string>();

                    if (!events.ContainsKey(id))
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if (!participantsList.Contains(participants[i]))
                            {
                                var nameParticipian = participants[i];
                                participantsList.Add(nameParticipian);
                            }
                        }

                        var innerDictionary = new Dictionary<string, List<string>>();
                        innerDictionary.Add(eventName, participantsList);
                        events.Add(id, innerDictionary);
                    }
                    else
                    {
                        if (events[id].ContainsKey(eventName))
                        {
                            for (int i = 0; i < participants.Count; i++)
                            {
                                if (!events[id][eventName].Contains(participants[i]))
                                {
                                    var participantName = participants[i];
                                    events[id][eventName].Add(participantName);
                                }
                            }
                        }
                    }
                }
            }

            var result = new Dictionary<string, List<string>>();

            foreach (var item in events)
            {
                foreach (var dict in item.Value)
                {
                    result.Add(dict.Key, dict.Value);
                }
            }

            foreach (var id in result.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{id.Key} - {id.Value.Count()}");

                foreach (var name in id.Value.OrderBy(x => x))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
