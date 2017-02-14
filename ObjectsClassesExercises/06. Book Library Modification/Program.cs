using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookCount = int.Parse(Console.ReadLine());

            var listOfBooks = new List<Book>();
            var titlesByDate = new Dictionary<string, DateTime>();

            for (int i = 0; i < bookCount; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var currentBook = new Book();
                currentBook.Title = input[0];
                currentBook.Author = input[1];
                currentBook.Publisher = input[2];
                currentBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                currentBook.Number = input[4];
                currentBook.Price = double.Parse(input[5]);
                listOfBooks.Add(currentBook);
            }

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);


            foreach (var book in listOfBooks)
            {
                titlesByDate.Add(book.Title, book.ReleaseDate);
            }

            foreach (var title in titlesByDate)
            {
                if (title.Value > date)
                {
                    Console.WriteLine($"{title.Key} -> {title.Value.Day}.{title.Value.Month}.{title.Value.Year}");
                }
            }
        }
    }
}
