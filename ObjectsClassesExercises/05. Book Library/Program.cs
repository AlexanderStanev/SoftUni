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

            for (int i = 0; i < bookCount; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var currentBook = new Book();
                currentBook.Title = input[0];
                currentBook.Author = input[1];
                currentBook.Publisher = input[2];
                currentBook.ReleaseDate = DateTime.ParseExact(input[3],"dd.MM.yyyy",CultureInfo.InvariantCulture);
                currentBook.Number = input[4];
                currentBook.Price = decimal.Parse(input[5]);
                listOfBooks.Add(currentBook);
            }

            
            foreach (var book in listOfBooks)
            {
                var 
                if ()
                {

                }
            }
        }
    }
}
