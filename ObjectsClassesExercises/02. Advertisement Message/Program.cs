﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var fakeAdsCount = int.Parse(Console.ReadLine());

            var phrases = new string[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            var events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            var authors = new string[] 
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            var cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            Random rng = new Random();

            for (int i = 0; i < fakeAdsCount; i++)
            {
                var phrasesIndex = rng.Next(0, phrases.Length);
                var eventsIndex = rng.Next(0, events.Length);
                var authorsIndex = rng.Next(0, authors.Length);
                var citiesIndex = rng.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phrasesIndex]} {events[eventsIndex]} {authors[authorsIndex]} – {cities[citiesIndex]}");
            }
        }
    }
}
