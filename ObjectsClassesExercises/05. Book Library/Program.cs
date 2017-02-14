using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookCount = int.Parse(Console.ReadLine());
            var listOfBooks = new List<Book>();
            var authors = new List<string>();

            for (int i = 0; i < bookCount; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var currentBook = new Book();
                currentBook.Title = input[0];
                currentBook.Author = input[1];
                currentBook.Publisher = input[2];
                currentBook.ReleaseDate = DateTime.ParseExact(input[3],"dd.MM.yyyy",CultureInfo.InvariantCulture);
                currentBook.Number = input[4];
                currentBook.Price = double.Parse(input[5]);
                listOfBooks.Add(currentBook);

                if (!authors.Contains(currentBook.Author))
                {
                    authors.Add(currentBook.Author);
                }
            }

            var listOfLibaries = new List<Library>();

            foreach (var author in authors)
            {
                var currentLiberary = new Library();
                currentLiberary.Books = new List<Book>();

                foreach (var book in listOfBooks)
                {
                    if (book.Author == author)
                    {
                        currentLiberary.Name = book.Author;
                        currentLiberary.Books.Add(book);
                    }
                }

                listOfLibaries.Add(currentLiberary);
            }

            var liberaryTotalPrice = new Dictionary<string, double>();
            foreach (var liberary in listOfLibaries)
            {
                liberaryTotalPrice.Add(liberary.Name,liberary.PriceOfAllBooks);
            }

            liberaryTotalPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var liberary in liberaryTotalPrice)
            {
                Console.WriteLine($"{liberary.Key} -> {liberary.Value:F2}");
            }

        }
    }
}
