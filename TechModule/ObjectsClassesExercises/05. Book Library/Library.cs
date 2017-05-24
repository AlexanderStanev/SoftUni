using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    public class Library
    {
        public string Name
        {
            get;
            set;
        }
        public List<Book> Books
        {
            get;
            set;
        }
        public double PriceOfAllBooks
        {
            get
            {
                double sum = 0;
                foreach (var book in Books)
                {
                    sum += book.Price;
                }
                return sum;
            }
        }
    }
}
