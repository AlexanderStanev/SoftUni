using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var singers = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            var songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            var currnetPerformance = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            var singersAwards = new Dictionary<string, HashSet<string>>();
            var uniqueAwards = new List<string>();
            while (currnetPerformance[0] != "dawn")
            {
                var singer = currnetPerformance[0].Trim();
                var song = currnetPerformance[1].Trim();
                var award = currnetPerformance[2].Trim();

                if (singers.Contains(singer) && songs.Contains(song)) 
                {
                    if (!singersAwards.ContainsKey(singer))
                    {
                        singersAwards[singer] = new HashSet<string>();
                    }

                    if (!uniqueAwards.Contains(award))
                    {
                        singersAwards[singer].Add(award);
                        uniqueAwards.Add(award);
                    }
                }

                currnetPerformance = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            if (singersAwards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var awardedSinger in singersAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (awardedSinger.Value.Count > 0)
                {
                    Console.WriteLine($"{awardedSinger.Key}: {awardedSinger.Value.Count} awards");

                    foreach (var awards in awardedSinger.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{awards}");
                    }
                }
            }
        }
    }
}
